using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadrastoContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        Contato Atualizar(Contato contato);
        Contato ListaPorId(int id);
        List<Contato>BuscarTodos();
        Contato Adcionar(Contato contato);
        Contato Remover(Contato contato);
    }
        
    }