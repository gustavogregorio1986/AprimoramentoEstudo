using Estudo3.Control;
using Estudo3.Control.Interfaces;
using Estudo3.Control.Observers;
using Estudo3.Entidade;
using System.Collections.Generic;

namespace Estudo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configura os observadores
            var observadores = new List<INotificacaoObserver>
            {
                new AuditoriaLog()
            };

            // Injeta as dependências no processador
            ProcessadorTransacao processador = new ProcessadorTransacao(observadores);

            // Simula transações
            Transacao t1 = new Transacao("TX-001", "Mariana Costa", 250.00m, "Pix");
            Transacao t2 = new Transacao("TX-002", "Roberto Dias", 1500.00m, "Cartao");

            processador.Executar(t1);
            processador.Executar(t2);
        }
    }
}