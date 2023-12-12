using Dapper;
using GenericRepository.Entity;

namespace GenericRepository.Dao
{
    internal class GenericRepository<T> : CommonDao, IGenericRepository<T> where T : BaseEntity
    {
        private readonly string _tableName;
        private readonly string _idKeyColumnName;
        private readonly string _insertSqlTemplate;
        private readonly string _updateSqlTemplate;

        public GenericRepository() : base()
        {
            var obj = BaseEntity.CreateEmptyInstance<T>();
            _tableName = obj.TableName;
            _idKeyColumnName = obj.IdKeyColumnName;
            _insertSqlTemplate = obj.InsertSqlTemplate;
            _updateSqlTemplate = obj.UpdateSqlTemplate;
        }

        public bool Delete(int id)
        {
            using var db = GetConnection();
            return db.Execute($@"delete from {_tableName} 
                    where {_idKeyColumnName} = @id;", new { id }) > 0;
        }

        public List<T>? GetAll()
        {
            using var db = GetConnection();
            return db.Query<T>($@"select * from {_tableName};").AsList();
        }

        public T? GetById(int id)
        {
            using var db = GetConnection();
            return db.QueryFirstOrDefault<T>($@"select * from {_tableName} 
                    where {_idKeyColumnName} = @id;", new { id });
        }

        public bool Insert(T entity)
        {
            using var db = GetConnection();
            return db.Execute(_insertSqlTemplate, entity) > 0;
        }

        public bool Update(T entity)
        {
            using var db = GetConnection();
            return db.Execute(_updateSqlTemplate, entity) > 0;
        }
    }
}
