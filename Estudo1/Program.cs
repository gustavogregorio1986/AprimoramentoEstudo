using Estudo1.Control;
using Estudo1.Entidade;

namespace Estudo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 32;

            Console.WriteLine($"O numero é: {valor.Numero}");

            ControlaValor controlaValor = new ControlaValor();
            controlaValor.ParEImpar(valor);
        }
    }
}
