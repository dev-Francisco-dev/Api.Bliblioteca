namespace WebAPIBiblioteca.Repository
{
    public interface IAuthoresRepository
    {
        List<Author> GetAll();
        Author Get(int id);
        void Insert(Author author);
        void Update(Author author);
        void Delete(int id);
    }
}
