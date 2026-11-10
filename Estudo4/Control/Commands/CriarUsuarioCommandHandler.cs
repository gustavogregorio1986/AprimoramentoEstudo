using Estudo4.Control.Repositories;
using Estudo4.Entidade;
using System;

namespace Estudo4.Control.Commands
{
    public class CriarUsuarioCommandHandler
    {
        private readonly IUsuarioRepository _repository;

        public CriarUsuarioCommandHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Handle(CriarUsuarioCommand command)
        {
            // Validações de negócio poderiam estar aqui
            Usuario usuario = new Usuario(command.Id, command.Nome, command.Email);
            _repository.Adicionar(usuario);
            Console.WriteLine($"[COMMAND] Usuário {usuario.Nome} criado e salvo com sucesso!");
        }
    }
}