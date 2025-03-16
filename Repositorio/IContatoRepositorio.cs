using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadrastoContatos.Repositorio
{
    public interface IContatoRepositorio
    {
         Contato ListaPorId(int id);
        List<Contato>BuscarTodos();
        Contato Adcionar(Contato contato);
        Contato Remover(Contato contato);
        Contato Atualizar(Contato contato);
    }
        
    }