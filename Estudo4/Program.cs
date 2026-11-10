using Estudo4.Control.Commands;
using Estudo4.Control.Mediator;
using Estudo4.Control.Queries;
using Estudo4.Control.Repositories;
using Estudo4.Entidade;
using System;

namespace Estudo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA COM ARQUITETURA CQRS + REPOSITORY + MEDIATOR (ESTUDO 4) ===");

            // 1. Instancia o repositório e o mediator central
            IUsuarioRepository repository = new UsuarioRepositoryInMemory();
            MediatorSimples mediator = new MediatorSimples(repository);

            // 2. Dispara um Comando (Escrita) para criar um usuário
            var comandoCriacao = new CriarUsuarioCommand(1, "Carlos Eduardo", "carlos@email.com");
            mediator.EnviarComando(comandoCriacao);

            Console.WriteLine();

            // 3. Dispara uma Query (Leitura) para buscar o usuário criado
            var queryBusca = new ObterUsuarioPorIdQuery(1);
            Usuario usuarioEncontrado = mediator.EnviarQuery(queryBusca);

            if (usuarioEncontrado != null)
            {
                Console.WriteLine($"[RESULTADO] Encontrado -> Nome: {usuarioEncontrado.Nome} | E-mail: {usuarioEncontrado.Email}");
            }
        }
    }
}