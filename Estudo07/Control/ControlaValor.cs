using Estudo07.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo07.Control
{
    public class ControlaValor
    {
        public int Adicao(Valor valor)
        {
            int calculo = 0;
            calculo = valor.Numero1 + valor.Numero2;
            return calculo;
        }

        public int Subtracao(Valor valor)
        {
            int calculo = 0;
            calculo = valor.Numero1 - valor.Numero2;
            return calculo;
        }

        public int Multiplicacao(Valor valor)
        {
            int calculo = 0;
            calculo = valor.Numero1 * valor.Numero2;
            return calculo;
        }

        public int Divisao(Valor valor)
        {
            int calculo = 0;

            try
            {
                
                calculo = valor.Numero1 / valor.Numero2;
            }
            catch(Exception ex)
            {
                throw new Exception("A divisão n]~]ao pode ser zero");
            }

            return calculo;
        }
    }
}
