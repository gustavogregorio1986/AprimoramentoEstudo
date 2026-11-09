using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo00.Entidade
{
    public class Aluno
    {
        public string Nome { get; set; }

        public string Escola { get; set; }
        public string Serie { get; set; }

        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }

        public Aluno()
        {
            
        }

        public Aluno(string nome, string escola, string serie, decimal nota1, decimal nota2)
        {
            this.Nome = nome;
            this.Escola = escola;
            this.Serie = serie;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
        }

        public override string ToString()
        {
            return Nome + "," + Escola + "," + Serie + "," + Nota1 + "," + Nota2;
        }
    }
}
