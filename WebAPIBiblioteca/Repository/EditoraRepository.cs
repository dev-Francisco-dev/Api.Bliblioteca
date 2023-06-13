using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class EditoraRepository : IEditoraRepository
    {
        private readonly DbContextBiblioteca _db;
        public EditoraRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Editora> GetAll()
        {
            var editoras = _db.Editoras.ToList();

            return editoras;
        }
        public Editora Get(int id)
        {
            var editora = _db.Editoras.Include(l => l.livros).FirstOrDefault(a => a.EditoraId == id);
            return editora!;
        }
        public void Insert(Editora editora)
        {
            _db.Editoras.Add(editora);
            _db.SaveChanges();
        }
        public void Update(Editora editora)
        {
            _db.Entry(editora).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
