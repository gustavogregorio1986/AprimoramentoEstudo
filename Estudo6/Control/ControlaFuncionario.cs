using Estudo6.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo6.Control
{
    public class ControlaFuncionario
    {
        public decimal Acrecimo(Funcionario funcionario)
        {
            decimal valor = 0.0m;

            if (funcionario.Salario >= 0.10m)
            {
                return funcionario.Salario * 0.10m;
            }
            else if (funcionario.Salario >= 0.20m)
            {
                return funcionario.Salario * 0.20m;

            }
            else if (funcionario.Salario >= 0.30m)
            {
                return funcionario.Salario * 0.30m;
            }
            else
            {
                return funcionario.Salario =+ funcionario.Salario;
            }
        }
    }
}
