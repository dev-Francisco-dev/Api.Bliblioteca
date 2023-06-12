namespace WebAPIBiblioteca.Repository
{
    public interface ILivrosRepository
    {
        List<Livro> GetAll();
        Livro Get(int id);
        void Insert(Livro livro);
        void Update(Livro livro);
        void Delete(int id);
    }
}
