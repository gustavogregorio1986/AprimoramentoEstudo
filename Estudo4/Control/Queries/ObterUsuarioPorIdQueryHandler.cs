using Estudo4.Control.Repositories;
using Estudo4.Entidade;
using System;

namespace Estudo4.Control.Queries
{
    public class ObterUsuarioPorIdQueryHandler
    {
        private readonly IUsuarioRepository _repository;

        public ObterUsuarioPorIdQueryHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario Handle(ObterUsuarioPorIdQuery query)
        {
            Console.WriteLine($"[QUERY] Buscando usuário com ID: {query.Id}...");
            return _repository.ObterPorId(query.Id);
        }
    }
}