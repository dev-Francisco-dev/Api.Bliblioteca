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
            var authores = _db.Authores!.ToList();
            return authores;
        }
        public Author Get(int id)
        {
            var author = _db.Authores!.FirstOrDefault(a => a.AuthorId == id);
            return author!;
        }
        public void Insert(Author author)
        {            
            _db.Authores!.Add(author);
            _db.SaveChanges();
        }
        public void Update(Author author)
        {
            _db.Entry(author).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
              
    }
}
