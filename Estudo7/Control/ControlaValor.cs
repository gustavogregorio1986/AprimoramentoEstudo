using Estudo7.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo7.Control
{
    public class ControlaValor
    {
        public void EstudoValor(Estudo estudo)
        {
            for(int i = 0; i <= estudo.Numero; i++)
            {
                Console.WriteLine("Valoir é: " + i);
            }
        }
    }
}
