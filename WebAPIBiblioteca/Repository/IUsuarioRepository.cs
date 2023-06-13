namespace WebAPIBiblioteca.Repository
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario Get(int id);
        void Insert(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
