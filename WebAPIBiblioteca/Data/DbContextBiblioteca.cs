using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;

namespace WebAPIBiblioteca.Data
{
    public class DbContextBiblioteca : DbContext
    {
        public DbContextBiblioteca(DbContextOptions<DbContextBiblioteca> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        protected override void OnModelCreating(ModelBuilder Modelbuider)
        {
            Modelbuider.Entity<Livro>().Property(a => a.LivroId).IsRequired();
            //Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
        }
    }
}
