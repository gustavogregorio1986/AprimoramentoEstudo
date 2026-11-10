using Estudo4.Entidade;
using System.Collections.Generic;

namespace Estudo4.Control.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        Usuario ObterPorId(int id);
    }
}