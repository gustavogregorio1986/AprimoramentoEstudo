using System;

namespace Estudo3.Entidade
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public string TipoCliente { get; set; } // "VIP" ou "Comum"

        public Pedido(int id, string cliente, decimal valorTotal, string tipoCliente)
        {
            Id = id;
            Cliente = cliente;
            ValorTotal = valorTotal;
            TipoCliente = tipoCliente;
        }
    }
}
