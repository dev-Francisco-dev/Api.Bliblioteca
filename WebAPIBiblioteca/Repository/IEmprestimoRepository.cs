namespace WebAPIBiblioteca.Repository
{
    public interface IEmprestimoRepository
    {
        List<Emprestimo> GetAll();
        Emprestimo Get(int id);
        void Insert(Emprestimo emprestimo);
        void Update(Emprestimo emprestimo);
        void Delete(int id);
    }
}
