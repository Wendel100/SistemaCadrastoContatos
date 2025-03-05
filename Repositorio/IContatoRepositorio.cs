using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadrastoContatos.Repositorio
{
    public interface IContatoRepositorio
    {
         Contato ListaPorId(int id);
        Contato Atualizar(Contato contato);
        List<Contato>BuscarTodos();
        Contato Adcionar(Contato contato);
        Contato Remover(Contato contato);
    }
        
    }