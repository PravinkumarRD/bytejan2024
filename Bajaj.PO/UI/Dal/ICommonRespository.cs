namespace UI.Dal
{
    //T = Type
    public interface ICommonRespository<T>
    {
        List<T> GetAll();
        T GetDetails(int id);
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
    }
}
