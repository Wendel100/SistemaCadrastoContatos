using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastroContatos.Models;
using SistemaDeCadrastoContatos.Repositorio;
namespace SistemaDeCadastroContatos.Controllers
{
    public class HomeController : Controller
    {
         private readonly IContatoRepositorio _repositorio;
        public HomeController(IContatoRepositorio contatoRepositorio)
        {
            _repositorio = contatoRepositorio;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            List<Contato> contatos=_repositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Editar(int id)
        {
            Contato contato = _repositorio.ListaPorId(id);
            return View(contato);
        }
        public IActionResult Apagar()
        {
            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            try
            {
              if (ModelState.IsValid)
            {
                _repositorio.Adcionar(contato);
                TempData["MensageSucesso"] = $"Contato criada com sucesso";
            }
             return RedirectToAction("Criar");
            }
            catch (System.Exception erro)
            {
                TempData["MensageErro"] = $"Possivel erro: {erro.Message}";
            }
        
            return View("criar",contato);
        }
        [HttpPost]
           public IActionResult Apagar(Contato contato)
        {
            if (contato != null)
            {
                _repositorio.Remover(contato);
                TempData["MenssageSucesso"] = $"Contato apagado com sucesso";
                  return RedirectToAction("Criar",contato);
            }
            else{
                TempData["MenssageErro"] = "Falha ao apagar contato";
            }
            return View();
        }
     [HttpPost]
        public IActionResult Alterar(Contato contato){
              if (ModelState.IsValid)
            {
            _repositorio.Atualizar(contato);
            return RedirectToAction("Criar");
            }
            return View("Editar",contato);
        }
}
}