using SistemaDeCadastroContatos.Data;
using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadrastoContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
         readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext){
            _bancoContext = bancoContext;
        }
        public Contato Adcionar(Contato contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
            
        }
}
}