using Azure.Messaging;
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
        public List<Livro> GetAll()
        {

            return _db.Livros.OrderBy(a => a.LivroId).ToList();
        }

        public Livro Get(int id)
        {
            var livro = _db.Livros.FirstOrDefault(a => a.LivroId == id);           
            return livro;
        }

        public void Insert(Livro livro)
        {
            _db.Livros.Add(livro);
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
