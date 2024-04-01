using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_usuarios.Model;

namespace api_usuarios.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void AdicionarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> BuscaUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            throw new NotImplementedException();
        }

        public void DeletarRegistroUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void EditarInfoUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}