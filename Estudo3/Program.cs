using Estudo3.Control;
using Estudo3.Control.Interfaces;
using Estudo3.Control.Observers;
using Estudo3.Control.Strategies;
using Estudo3.Entidade;

namespace Estudo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Criação das dependências (Estratégias e Observadores)
            var estrategiasDesconto = new List<IDescontoStrategy>
            {
                new DescontoClienteVip(),
                new DescontoClienteComum()
            };

            var observadoresNotificacao = new List<INotificacaoObserver>
            {
                new NotificacaoEmail(),
                new NotificacaoSms()
            };

            // 2. Injeta as dependências no Gerenciador (Controller)
            GerenciadorPedido gerenciador = new GerenciadorPedido(estrategiasDesconto, observadoresNotificacao);

            // 3. Simula pedidos de clientes diferentes
            Pedido pedido1 = new Pedido(101, "Carlos Silva", 1200.00m, "VIP");
            Pedido pedido2 = new Pedido(102, "Ana Souza", 300.00m, "Comum");

            gerenciador.ProcessarCheckout(pedido1);
            gerenciador.ProcessarCheckout(pedido2);
        }
    }
}