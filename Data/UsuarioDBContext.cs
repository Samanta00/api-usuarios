
using api_usuarios.Model;
using Microsoft.EntityFrameworkCore;

namespace api_usuarios.Data
{
    public class UsuarioDBContext : DbContext
    {
        public UsuarioDBContext(DbContextOptions <UsuarioDBContext> options) : base(options)
        {
        }
        public DbSet<Usuario> usuarios {get; set;}
    }
}