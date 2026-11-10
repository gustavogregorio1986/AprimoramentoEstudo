using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo05.Entidade
{
    public class Empresa
    {
        public string NomeEmpresa { get; set; }

        public string Cnpj { get; set; }

        public int AnoSurgimento { get; set; }

        public int QtdeDeFuncionarios { get; set; }

        public Empresa()
        {
                
        }

        public Empresa(string nomeEmpresa, string cnpj, int AnoSurgimento, int QtdeDeFuncionarios)
        {
            this.NomeEmpresa = nomeEmpresa;
            this.Cnpj = cnpj;
            this.AnoSurgimento = AnoSurgimento;
            this.QtdeDeFuncionarios = QtdeDeFuncionarios;
        }

        public override string ToString()
        {
            return NomeEmpresa + "," + Cnpj + "," + AnoSurgimento + "," + QtdeDeFuncionarios
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                ;
        }
    }
}
