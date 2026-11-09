using Estudo00.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo00.Control
{
    public class ControlaAluno
    {
        public decimal Media(Aluno aluno)
        {
            decimal media = 0;
            media = (aluno.Nota1 + aluno.Nota2) / 2;
            return media;
        }

        public void SituacaoAluno(Aluno aluno)
        {
            if(Media(aluno) >= 7)
            {
                Console.WriteLine("Aprovado");
            }else if (Media(aluno) >= 4)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
