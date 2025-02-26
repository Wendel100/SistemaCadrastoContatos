using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadrastoContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<Contato>BuscarTodos();
        Contato Adcionar(Contato contato);
    }
        
    }