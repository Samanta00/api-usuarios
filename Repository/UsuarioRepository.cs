
using api_usuarios.Data;
using api_usuarios.Model;
using Microsoft.EntityFrameworkCore;


namespace api_usuarios.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDBContext _context;


        public UsuarioRepository(UsuarioDBContext context)
        {
            _context = context;
        }
        public void AdicionarUsuario(Usuario usuario)
        {
            _context.Add(usuario);
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