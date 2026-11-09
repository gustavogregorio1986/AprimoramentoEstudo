using Estudo3.Control.Interfaces;
using Estudo3.Entidade;
using System;

namespace Estudo3.Control.Observers
{
    public class AuditoriaLog : INotificacaoObserver
    {
        public void Executar(Transacao transacao)
        {
            Console.WriteLine($"[AUDITORIA] Transação {transacao.Id} atualizada para: {transacao.Status}\n");
        }
    }
}