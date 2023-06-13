namespace WebAPIBiblioteca.Repository
{
    public interface IComentarioRepository
    {
        List<Comentario> GetAll();
        Comentario Get(int id);
        void Insert(Comentario comentario);
        void Update(Comentario comentario);
        void Delete(int id);
    }
}
