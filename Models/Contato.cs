using System.ComponentModel.DataAnnotations;

namespace SistemaDeCadastroContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="digite o nome do contato!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="digite um Email!")]
        [EmailAddress(ErrorMessage ="digite o nome de Email valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="digite um numero!")]
        [Phone(ErrorMessage ="O numero de celular e invalido")]
        public string Phone { get; set; }
        public Contato(){}
        public Contato(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}