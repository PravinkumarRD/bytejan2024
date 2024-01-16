namespace UI.Dal
{
    //T = Type
    public class CommonRespository<T> : ICommonRespository<T> where T : class
    {
        private readonly List<T> _db;
        public CommonRespository()
        {
            _db = new List<T>();
        }

        public List<T> GetAll()
        {
            return _db;
        }

        public T GetDetails(int id)
        {
            return _db[id];
        }

        public void Insert(T item)
        {
            _db.Add(item);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
        public void Delete(T item)
        {
            throw new NotImplementedException();
        }
    }
}
