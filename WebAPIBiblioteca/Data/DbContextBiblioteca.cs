using Microsoft.EntityFrameworkCore;

namespace WebAPIBiblioteca.Data
{
    public class DbContextBiblioteca : DbContext
    {
        public DbContextBiblioteca(DbContextOptions<DbContextBiblioteca> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Author>? Authores { get; set; }
        public DbSet<Editora>? Editoras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo>? Emprestimos { get; set; }
        public DbSet<Comentario>? comentarios { get; set; }


        protected override void OnModelCreating(ModelBuilder Modelbuilder)
        {                      
            Modelbuilder.Entity<Livro>().HasMany(l => l.Categorias).WithMany(c => c.Livros);          
            Modelbuilder.Entity<Livro>().HasMany(l => l.Authors).WithMany(c => c.livros);
            Modelbuilder.Entity<Editora>().HasMany(e => e.livros).WithMany(l => l.Editoras);           


            Modelbuilder.Entity<Usuario>().HasMany(u => u.Emprestimos).WithOne(e => e.Usuario).HasForeignKey(e => e.UsuarioId);
            Modelbuilder.Entity<Livro>().HasMany(u => u.Emprestimos).WithOne(e => e.Livro).HasForeignKey(e => e.LivroId);

            Modelbuilder.Entity<Usuario>().HasMany(u => u.Comentarios).WithOne(e => e.Usuario).HasForeignKey(e => e.UsuarioId);
            Modelbuilder.Entity<Livro>().HasMany(u => u.Comentarios).WithOne(e => e.Livro).HasForeignKey(e => e.LivroId);

                    

            //Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
        }
    }
}
