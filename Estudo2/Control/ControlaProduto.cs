using Estudo2.Entidade;
using System;
using System.Collections.Generic;

namespace Estudo2.Control
{
    public class ControlaProduto
    {
        private readonly List<Produto> _listaProdutos;

        public ControlaProduto()
        {
            _listaProdutos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _listaProdutos.Add(produto);
        }

        public void ExibirProdutos()
        {
            Console.WriteLine("\n=== RELATÓRIO DE ESTOQUE (ESTUDO 2) ===");
            foreach (var prod in _listaProdutos)
            {
                Console.WriteLine($"Produto: {prod.Nome} | Preço: R$ {prod.Preco:F2} | Qtd: {prod.QuantidadeEstoque} | Total: R$ {prod.CalcularValorTotalEstoque():F2}");
            }
        }
    }
}