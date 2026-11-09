using Estudo3.Control.Interfaces;
using Estudo3.Control.Strategies;
using System;

namespace Estudo3.Control.Factories
{
    public static class PagamentoFactory
    {
        public static IPagamentoStrategy Criar(string metodo)
        {
            return metodo switch
            {
                "Pix" => new PagamentoPix(),
                "Cartao" => new PagamentoCartaoCredito(),
                _ => throw new ArgumentException("Método de pagamento inválido!")
            };
        }
    }
}