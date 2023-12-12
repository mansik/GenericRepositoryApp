namespace GenericRepository.Entity
{
    internal abstract class BaseEntity
    {
        public abstract string TableName { get; }
        public abstract string IdKeyColumnName { get; }
        public abstract string InsertSqlTemplate { get; }
        public abstract string UpdateSqlTemplate { get; }

        private static readonly Dictionary<string, BaseEntity> _entities = [];
        public static BaseEntity CreateEmptyInstance<T>()
        {
            var key = typeof(T).FullName;
            if (!_entities.TryGetValue(key, out BaseEntity? value))
            {
                var obj = Activator.CreateInstance<T>() as BaseEntity;
                value = obj;
                _entities.Add(key, value);
            }
            return value;
        }
    }
}
