using Estudo4.Control.Commands;
using Estudo4.Control.Queries;
using Estudo4.Entidade;
using Estudo4.Control.Repositories;

namespace Estudo4.Control.Mediator
{
    public class MediatorSimples
    {
        private readonly CriarUsuarioCommand _criacaoHandler; // (ou injetando via DI)
        private readonly CriarUsuarioCommandHandler _criarHandler;
        private readonly ObterUsuarioPorIdQueryHandler _obterHandler;

        public MediatorSimples(IUsuarioRepository repository)
        {
            _criarHandler = new CriarUsuarioCommandHandler(repository);
            _obterHandler = new ObterUsuarioPorIdQueryHandler(repository);
        }

        public void EnviarComando(CriarUsuarioCommand command)
        {
            _criarHandler.Handle(command);
        }

        public Usuario EnviarQuery(ObterUsuarioPorIdQuery query)
        {
            return _obterHandler.Handle(query);
        }
    }
}