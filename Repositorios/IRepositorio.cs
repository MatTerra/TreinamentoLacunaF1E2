namespace Projeto.Repositorios
{
    interface IRepositorio<T>
    {
        public void Add(T entry);
        public List<T> GetAll();
        public T Get(string name);
    }
}
