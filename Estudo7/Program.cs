using Estudo7.Control;
using Estudo7.Entidade;

namespace Estudo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudo estudo = new Estudo();
            estudo.Numero = 10;
            Console.WriteLine("Numero: " + estudo.Numero);

            ControlaValor controlaValor = new ControlaValor();
            controlaValor.EstudoValor(estudo);
        }
    }
}
