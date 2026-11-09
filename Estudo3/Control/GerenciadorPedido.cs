using Estudo3.Control.Interfaces;
using Estudo3.Control.Strategies;
using Estudo3.Entidade;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo3.Control
{
    public class GerenciadorPedido
    {
        private readonly IEnumerable<IDescontoStrategy> _descontoStrategies;
        private readonly IEnumerable<INotificacaoObserver> _notificacaoObservers;

        // Injeção de Dependências por Coleções (Inversion of Control)
        public GerenciadorPedido(
            IEnumerable<IDescontoStrategy> descontoStrategies,
            IEnumerable<INotificacaoObserver> notificacaoObservers)
        {
            _descontoStrategies = descontoStrategies;
            _notificacaoObservers = notificacaoObservers;
        }

        public void ProcessarCheckout(Pedido pedido)
        {
            Console.WriteLine($"\n--- Processando Pedido #{pedido.Id} para {pedido.Cliente} ({pedido.TipoCliente}) ---");

            // 1. Descobre qual estratégia de desconto aplicar com base no tipo do cliente
            IDescontoStrategy strategy = pedido.TipoCliente switch
            {
                "VIP" => _descontoStrategies.OfType<DescontoClienteVip>().FirstOrDefault(),
                _ => _descontoStrategies.OfType<DescontoClienteComum>().FirstOrDefault()
            };

            decimal desconto = strategy != null ? strategy.CalcularDesconto(pedido) : 0;
            decimal valorFinal = pedido.ValorTotal - desconto;

            Console.WriteLine($"Valor Original: R$ {pedido.ValorTotal:F2} | Desconto: R$ {desconto:F2} | Valor Final: R$ {valorFinal:F2}");

            // 2. Dispara todos os observadores cadastrados (E-mail, SMS, etc.)
            foreach (var observer in _notificacaoObservers)
            {
                observer.Notificar(pedido);
            }
        }
    }
}
