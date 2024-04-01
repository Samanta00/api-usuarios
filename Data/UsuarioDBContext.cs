
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

                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario = modelBuilder.Entity<Usuario>();

            usuario.ToTable("table_register_usuario");
            usuario.HasKey(x => x.ID);
            usuario.Property(x => x.ID).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.Profissao).HasColumnName("profissao");
            usuario.Property(x => x.Departamento).HasColumnName("departamento");
            usuario.Property(x => x.Cidade).HasColumnName("cidade");
            usuario.Property(x => x.DataNascimento).HasColumnName("data_nascimento");


        }
    }
}