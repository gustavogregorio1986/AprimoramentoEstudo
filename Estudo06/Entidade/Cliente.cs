using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo06.Entidade
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public Endereco Endereco { get; set; }

        public List<Telefone> Telefones { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, string email, string cpf)
        {
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return Nome + "," + Email + "," + Cpf;
        }
    }
}
