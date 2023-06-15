using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly DbContextBiblioteca _db;
        public ComentarioRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Comentario> GetAll()
        {
            var coment = _db.comentarios!.ToList();

            return coment!;
        }
        public Comentario Get(int id)
        {
            var coment = _db.comentarios!.FirstOrDefault(a => a.ComentarioId == id);
            return coment!;
        }
        public void Insert(Comentario comentario)
        {
            _db.comentarios!.Add(comentario);
            _db.SaveChanges();
        }
        public void Update(Comentario comentario)
        {
            _db.Entry(comentario).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
