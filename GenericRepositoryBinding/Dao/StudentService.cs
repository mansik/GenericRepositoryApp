using GenericRepository.Entity;

namespace GenericRepository.Dao
{
    internal class StudentService(IGenericRepository<Student> dao) : IGenericRepository<Student>
    {
        private readonly IGenericRepository<Student> _dao = dao;

        public bool Delete(int id)
        {
            return _dao.Delete(id);
        }

        public List<Student>? GetAll()
        {
            return _dao.GetAll();
        }

        public Student? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public bool Insert(Student entity)
        {
            return _dao.Insert(entity);
        }

        public bool Update(Student entity)
        {
            return _dao.Insert(entity);
        }
    }
}
