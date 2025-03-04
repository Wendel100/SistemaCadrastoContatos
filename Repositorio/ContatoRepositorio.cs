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
               public Contato Remover(Contato contato)
        {
            _bancoContext.Contatos.Remove(contato);
            _bancoContext.SaveChanges();
            return contato;

        }            public Contato Atualizar(Contato contato)
        {
            Contato contatoDB = ListaPorId(contato.Id);

            if(contatoDB == null){
                throw new System.Exception("Erro ao atualizar os dados");
            }
            else{
                contatoDB.Name = contato.Name;
                contatoDB.Email = contato.Email;
                contatoDB.Phone = contato.Phone;
                _bancoContext.Contatos.Update(contatoDB);
                _bancoContext.SaveChanges();
                return contatoDB;
            }
        }
        public Contato ListaPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<Contato> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
                public Contato Adcionar(Contato contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
            
        }
    }
}