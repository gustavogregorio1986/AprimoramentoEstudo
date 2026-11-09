using Estudo3.Control.Interfaces;
using Estudo3.Entidade;

namespace Estudo3.Control.Strategies
{
    public class DescontoClienteComum : IDescontoStrategy
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            // Cliente comum ganha 5% de desconto
            return pedido.ValorTotal * 0.05m;
        }
    }
}