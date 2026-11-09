using Estudo1.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.Control
{
    public class ControlaValor
    {
        public void ParEImpar(Valor valor)
        {
            if(valor.Numero % 2 == 0)
            {
                Console.WriteLine($"O numero par é: {valor.Numero}");
            }
            else
            {
                Console.WriteLine($"O numero impar é: {valor.Numero}");
            }
        }
    }
}
