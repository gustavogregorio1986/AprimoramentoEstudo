using Estudo2.Control;
using Estudo2.Entidade;
using System;

namespace Estudo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o projeto Estudo2...");

            // Instancia o controlador
            ControlaProduto controlador = new ControlaProduto();

            // Cadastra novos produtos (Entidades)
            controlador.AdicionarProduto(new Produto("Notebook", 3500.00, 4));
            controlador.AdicionarProduto(new Produto("Mouse Gamer", 150.00, 12));
            controlador.AdicionarProduto(new Produto("Teclado Mecânico", 300.00, 7));

            // Executa a exibição via controladora
            controlador.ExibirProdutos();
        }
    }
}