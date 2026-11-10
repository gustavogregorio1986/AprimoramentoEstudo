using Estudo4.Entidade;
using System.Collections.Generic;
using System.Linq;

namespace Estudo4.Control.Repositories
{
    public class UsuarioRepositoryInMemory : IUsuarioRepository
    {
        private static readonly List<Usuario> _bancoDeDadosFalso = new List<Usuario>();

        public void Adicionar(Usuario usuario)
        {
            _bancoDeDadosFalso.Add(usuario);
        }

        public Usuario ObterPorId(int id)
        {
            return _bancoDeDadosFalso.FirstOrDefault(u => u.Id == id);
        }
    }
}