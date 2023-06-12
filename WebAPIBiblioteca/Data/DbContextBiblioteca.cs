using Microsoft.EntityFrameworkCore;

namespace WebAPIBiblioteca.Data
{
    public class DbContextBiblioteca : DbContext
    {
        public DbContextBiblioteca(DbContextOptions<DbContextBiblioteca> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Author> Authores { get; set; }
        protected override void OnModelCreating(ModelBuilder Modelbuider)
        {
            Modelbuider.Entity<Livro>().Property(a => a.LivroId).IsRequired();
            Modelbuider.Entity<Categoria>().Property(a => a.CategoriaId).IsRequired();
            Modelbuider.Entity<Livro>().HasMany(l => l.Categorias).WithMany(c => c.Livros);
            Modelbuider.Entity<Author>().Property(a => a.AuthorId).IsRequired();
            Modelbuider.Entity<Livro>().HasMany(l => l.Authors).WithMany(c => c.livros);

            //Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
        }
    }
}
