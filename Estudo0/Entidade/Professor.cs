using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo0.Entidade
{
    public class Professor
    {
        public string NomeProf { get; set; }
        public string EmailProf { get; set; }
        public string CpfProf { get; set; }

        public int QutdeAulas { get; set; }

        public List<Escola> Escolas { get; set; }
    }
}
