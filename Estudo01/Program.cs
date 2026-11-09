using Estudo01.Control;
using Estudo01.Entidade;

namespace Estudo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudo estudo = new Estudo();
            estudo.Numero = 2;
            Console.WriteLine("Numero: " + estudo.Numero);

            ControlaEstudo controlaEstudo = new ControlaEstudo();
            controlaEstudo.Alternativas(estudo);
        }
    }
}