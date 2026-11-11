using Estudo06.Entidade;

namespace Estudo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Laio";
            cliente.Email = "laio@gmail.com";
            cliente.Cpf = "0987654321";

            cliente.Endereco = new Endereco()
            {
                Logradouro = "Rua x",
                Complemento = "numero 89",
                Bairro = "Flamengo",
                Cidade = "Rio de Janeiro",
                Estado = "RJ"
            };

            Console.WriteLine("Nome do Cliente: " + cliente.Nome);
            Console.WriteLine("Email do Cliente: " + cliente.Email);
            Console.WriteLine("Cpf do Cliente: " + cliente.Cpf);

            Console.WriteLine("Logradouro: " + cliente.Endereco.Logradouro);
            Console.WriteLine("Complemento " + cliente.Endereco.Complemento);
            Console.WriteLine("Bairro: " + cliente.Endereco.Bairro);
            Console.WriteLine("Cidade: " + cliente.Endereco.Cidade);
            Console.WriteLine("Estado: " + cliente.Endereco.Estado);




            List<Telefone> listaTel = new List<Telefone>()
            {
                new Telefone("Reiidencia","243565554"),
                new Telefone("Celular","97567778")
            };

            foreach (var item in listaTel)
            {
                // Substitua 'Tipo' e 'Numero' pelos nomes reais dos atributos da sua classe Telefone
                Console.WriteLine($"{item.Tipo}: {item.Numero}");
            }


        }
    }
}
