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
        public IActionResult Editar()
        {
            return View();
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
            if (ModelState.IsValid)
            {
                     _repositorio.Adcionar(contato);
                // Salvar os dados no banco de dados ou realizar outra ação
                return RedirectToAction("Criar");
            }
            return View(contato);
        }
    }
}
