using Estudo3.Entidade;

namespace Estudo3.Control.Interfaces
{
    public interface IPagamentoStrategy
    {
        bool Processar(Transacao transacao);
    }
}