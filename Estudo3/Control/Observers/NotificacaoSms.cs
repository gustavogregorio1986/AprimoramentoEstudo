using Estudo3.Control.Interfaces;
using Estudo3.Entidade;
using System;

namespace Estudo3.Control.Observers
{
    public class NotificacaoSms : INotificacaoObserver
    {
        public void Notificar(Pedido pedido)
        {
            Console.WriteLine($"[SMS] Alerta: Pedido #{pedido.Id} processado para o celular do cliente {pedido.Cliente}.");
        }
    }
}