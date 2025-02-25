using System.Reflection.Metadata;
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
            return View();
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
            _repositorio.Adcionar(contato);
            return RedirectToAction("Index");
        }
    }
}
