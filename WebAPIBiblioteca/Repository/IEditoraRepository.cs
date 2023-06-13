namespace WebAPIBiblioteca.Repository
{
    public interface IEditoraRepository
    {
        List<Editora> GetAll();
        Editora Get(int id);
        void Insert(Editora editora);
        void Update(Editora editora);
        void Delete(int id);
    }
}
