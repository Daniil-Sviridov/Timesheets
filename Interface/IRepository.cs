namespace Timesheets.Interface
{
    public interface IRepository<T> where T : class
    {
        public IList<T> GetAll();

        public IList<T> GetFromTo(int fromId, int toId);

        public T GetById(int id);

        public void Create(T item);

        public void Update(T item);

        public void Delete(int id);
    }
}
