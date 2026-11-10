namespace Estudo4.Control.Commands
{
    public class CriarUsuarioCommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public CriarUsuarioCommand(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}