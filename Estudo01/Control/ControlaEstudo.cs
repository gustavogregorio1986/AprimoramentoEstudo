using Estudo01.Entidade;

namespace Estudo01.Control
{
    public class ControlaEstudo
    {
        private readonly ValidadorAlternativas _validador;

        public ControlaEstudo()
        {
            // Instancia a classe separada
            _validador = new ValidadorAlternativas();
        }

        public void Alternativas(Estudo estudo)
        {
            // Pede para a classe separada processar o switch usando o número do objeto
            _validador.Processar(estudo.Numero);
        }
    }
}