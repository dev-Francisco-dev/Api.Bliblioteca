using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbContextBiblioteca _db;
        public UsuarioRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Usuario> GetAll()
        {
            var usuarios = _db.Usuarios.ToList();
            return usuarios;
        }
        public Usuario Get(int id)
        {
            var users = _db.Usuarios.Include(l => l.Comentarios).FirstOrDefault(a => a.UsuarioId == id);
            return users;
        }
        public void Insert(Usuario usuario)
        {            
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }
        public void Update(Usuario usuario)
        {
            var user = _db.Authores.Find(Get(usuario.UsuarioId));
            if(user == null)
            {
                _db.Add(user);
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
