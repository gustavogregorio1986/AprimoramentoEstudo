using Estudo6.Control;
using Estudo6.Entidade;

namespace Estudo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.NomeFunc = "Pedro";
            funcionario.EmailFunc = "pedro@gmail.com";
            funcionario.Cpf = "1234567890";
            funcionario.Salario = 4300;

            Console.WriteLine($"Nome do Funcionario: {funcionario.NomeFunc}");
            Console.WriteLine($"Email do Funcionario: {funcionario.EmailFunc}");
            Console.WriteLine($"Cpf do Funcionario: {funcionario.Cpf}");
            Console.WriteLine($"Salario do Funcionario: {funcionario.Salario}");

            ControlaFuncionario controlaFuncionario = new ControlaFuncionario();
            Console.WriteLine(controlaFuncionario.Acrecimo(funcionario));


        }
    }
}
