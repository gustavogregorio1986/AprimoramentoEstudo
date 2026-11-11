using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo06.Entidade
{
    public class Telefone
    {
        public string Tipo { get; set; }

        public string Numero { get; set; }

        public Telefone()
        {
            
        }

        public Telefone(string tipo, string numero)
        {
            this.Tipo = tipo;
            this.Numero = numero;
        }

        public override string ToString()
        {
            return Tipo + "," + Numero;
        }
    }
}
