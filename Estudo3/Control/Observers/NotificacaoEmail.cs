using Estudo3.Control.Interfaces;
using Estudo3.Entidade;
using System;

namespace Estudo3.Control.Observers
{
    public class NotificacaoEmail : INotificacaoObserver
    {
        public void Notificar(Pedido pedido)
        {
            Console.WriteLine($"[E-MAIL] Olá {pedido.Cliente}, seu pedido #{pedido.Id} foi aprovado com sucesso!");
        }
    }
}