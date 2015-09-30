namespace CarSales.Dal.Interfaces.Base
{
    public interface IData<T>
    {
        T GetById(decimal id);

        decimal Add(T item);

        bool Update(T item);

        bool RemoveById(decimal id);
    }
}
