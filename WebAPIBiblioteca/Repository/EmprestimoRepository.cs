using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data;

namespace WebAPIBiblioteca.Repository
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly DbContextBiblioteca _db;
        public EmprestimoRepository(DbContextBiblioteca db)
        {
            _db = db;
        }
        public List<Emprestimo> GetAll()
        {
            var emprestimos = _db.Emprestimos!.ToList();
            return emprestimos;
        }
        public Emprestimo Get(int id)
        {
            var emprestimo = _db.Emprestimos!.FirstOrDefault(a => a.EmprestimoId == id);
            return emprestimo!;
        }
        public void Insert(Emprestimo emprestimo)
        {
            _db.Emprestimos!.Add(emprestimo);
            _db.SaveChanges();
        }
        public void Update(Emprestimo emprestimo)
        {
            _db.Entry(emprestimo).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
