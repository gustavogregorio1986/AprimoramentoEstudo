using System;
namespace Estudo2.Entidade
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        // Construtor para inicializar o produto
        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        // Método para calcular o valor total em estoque (Preço * Quantidade)
        public double CalcularValorTotalEstoque()
        {
            return Preco * QuantidadeEstoque;
        }
    }
}