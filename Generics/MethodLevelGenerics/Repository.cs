using MethodLevelGenerics.Entities;

namespace MethodLevelGenerics
{
    public class Repository
    {
        private readonly DataBase _dataBase;

        public Repository()
        {
            _dataBase = new DataBase();
        }

        public int Save<T>(T entity) where T : Entity
        {
            return _dataBase.Save(entity);
        }

        public T GetById<T>(int id) where T : Entity
        {
            return _dataBase.GetById(id) as T;
        }        
    }
}