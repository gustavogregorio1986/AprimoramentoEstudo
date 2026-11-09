using Estudo3.Entidade;

namespace Estudo3.Control.Interfaces
{
    public interface IDescontoStrategy
    {
        decimal CalcularDesconto(Pedido pedido);
    }
}