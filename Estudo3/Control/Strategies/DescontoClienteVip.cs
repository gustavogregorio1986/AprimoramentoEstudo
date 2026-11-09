using Estudo3.Control.Interfaces;
using Estudo3.Entidade;

namespace Estudo3.Control.Strategies
{
    public class DescontoClienteVip : IDescontoStrategy
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            // VIP ganha 20% de desconto
            return pedido.ValorTotal * 0.20m;
        }
    }
}