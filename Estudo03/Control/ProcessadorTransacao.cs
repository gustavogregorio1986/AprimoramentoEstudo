using Estudo3.Control.Factories;
using Estudo3.Control.Interfaces;
using Estudo3.Entidade;
using System;
using System.Collections.Generic;

namespace Estudo3.Control
{
    public class ProcessadorTransacao
    {
        private readonly IEnumerable<INotificacaoObserver> _observers;

        public ProcessadorTransacao(IEnumerable<INotificacaoObserver> observers)
        {
            _observers = observers;
        }

        public void Executar(Transacao transacao)
        {
            Console.WriteLine($"--- Processando Transação [{transacao.Id}] ---");

            try
            {
                IPagamentoStrategy strategy = PagamentoFactory.Criar(transacao.MetodoEscolhido);
                bool sucesso = strategy.Processar(transacao);

                transacao.Status = sucesso ? StatusTransacao.Aprovado : StatusTransacao.Rejeitado;
            }
            catch (Exception ex)
            {
                transacao.Status = StatusTransacao.Rejeitado;
                Console.WriteLine($"[ERRO] {ex.Message}");
            }

            foreach (var observer in _observers)
            {
                observer.Executar(transacao);
            }
        }
    }
}