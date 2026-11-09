using Estudo3.Control.Interfaces;
using Estudo3.Entidade;
using System;

namespace Estudo3.Control.Strategies
{
    public class PagamentoCartaoCredito : IPagamentoStrategy
    {
        public bool Processar(Transacao transacao)
        {
            decimal valorComTaxa = transacao.Valor * 1.03m;
            Console.WriteLine($"[CARTÃO] Consultando operadora... Valor com taxa: R$ {valorComTaxa:F2}");
            return true;
        }
    }
}