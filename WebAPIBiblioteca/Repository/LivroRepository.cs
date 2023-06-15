using Domain.Models;
using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class LivroRepository : ILivrosRepository
    {
        private readonly DbContextBiblioteca _db;
        public LivroRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Livro>GetAll()
        {
            var livros = _db.Livros.ToList();                                   

                return livros;
        }
        public Livro Get(int id)
        {
            var livro = _db.Livros.FirstOrDefault(a => a.LivroId == id);
          
            return livro!;
        }
        public void Insert(Livro livro)
        {
            _db.Add(livro);
            _db.SaveChanges();
        }
        public void Update(Livro livro)
        {
            _db.Entry(livro).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
