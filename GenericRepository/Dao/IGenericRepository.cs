namespace GenericRepository.Dao
{
    internal interface IGenericRepository<T>
    {
        List<T>? GetAll();
        T? GetById(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
