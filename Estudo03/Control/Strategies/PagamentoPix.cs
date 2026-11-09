using Estudo3.Control.Interfaces;
using Estudo3.Entidade;
using System;

namespace Estudo3.Control.Strategies
{
    public class PagamentoPix : IPagamentoStrategy
    {
        public bool Processar(Transacao transacao)
        {
            Console.WriteLine($"[PIX] Gerando QR Code para {transacao.Cliente} no valor de R$ {transacao.Valor:F2}...");
            return transacao.Valor > 0;
        }
    }
}