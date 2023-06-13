using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class AuthoresRepository : IAuthoresRepository
    {
        private readonly DbContextBiblioteca _db;
        public AuthoresRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Author> GetAll()
        {
            var authores = _db.Authores.ToList();
            return authores;
        }
        public Author Get(int id)
        {
            var author = _db.Authores.Include(l => l.livros).FirstOrDefault(a => a.AuthorId == id);
            return author;
        }
        public void Insert(Author author)
        {            
            _db.Authores.Add(author);
            _db.SaveChanges();
        }
        public void Update(Author author)
        {
            var autors = _db.Authores.Find(Get(author.AuthorId));
            if(autors == null)
            {
                _db.Add(author);
                _db.SaveChanges();
            }
            
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
              
    }
}
