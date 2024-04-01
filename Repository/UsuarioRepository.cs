
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

        public async Task<Usuario> BuscaUsuarioPorId(int id)
        {
            return await _context.usuarios.Where(x => x.ID == id).FirstOrDefaultAsync();
        
        }

        public async Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            return await _context.usuarios.ToListAsync();
        }

        public void DeletarRegistroUsuario(Usuario usuario)
        {
            _context.usuarios.Remove(usuario);
        }

        public void EditarInfoUsuario(Usuario usuario)
        {
            _context.Update(usuario);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
            
        }
    }
}