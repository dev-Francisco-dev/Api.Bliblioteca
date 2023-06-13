namespace WebAPIBiblioteca.Repository
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();
        Categoria Get(int id);
        void Insert(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(int id);
    }
}
