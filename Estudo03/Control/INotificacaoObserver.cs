using Estudo3.Entidade;

namespace Estudo3.Control.Interfaces
{
    public interface INotificacaoObserver
    {
        void Executar(Transacao transacao);
    }
}