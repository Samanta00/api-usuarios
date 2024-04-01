
using api_usuarios.Model;

namespace api_usuarios.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> BuscaUsuarios();
        Task<Usuario> BuscaUsuarioPorId(int id);
        void AdicionarUsuario(Usuario usuario);

        void EditarInfoUsuario(Usuario usuario);

        void DeletarRegistroUsuario(Usuario usuario);
        
        Task<bool>SaveChangesAsync();
    }
}