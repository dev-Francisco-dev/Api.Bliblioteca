using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DbContextBiblioteca _db;
        public CategoriaRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Categoria> GetAll()
        {
            var Categoria = _db.Categorias.ToList();

            return Categoria;
        }
        public Categoria Get(int id)
        {
            var categ = _db.Categorias.Include(l => l.Livros).FirstOrDefault(a => a.CategoriaId == id);
            return categ;
        }
        public void Insert(Categoria categoria)
        {
            _db.Categorias.Add(categoria);
            _db.SaveChanges();
        }
        public void Update(Categoria categoria)
        {
            _db.Entry(categoria).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
      
    }
}
