using Estudo07.Control;
using Estudo07.Entidade;

namespace Estudo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero1 = 32;
            valor.Numero2 = 2;

            Console.WriteLine("Numero1: " + valor.Numero1);
            Console.WriteLine("Numero2: " + valor.Numero2);

            ControlaValor controlaValor = new ControlaValor();
            Console.WriteLine("A soma é: " + controlaValor.Adicao(valor));
            Console.WriteLine("A subtração é: " + controlaValor.Subtracao(valor));
            Console.WriteLine("A divisão é: " + controlaValor.Divisao(valor));


        }
    }
}
