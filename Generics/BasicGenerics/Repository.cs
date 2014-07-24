using BasicGenerics.Entities;

namespace BasicGenerics
{
    public class Repository <T> where T : Entity
    {
        private readonly DataBase _dataBase;

        public Repository()
        {
            _dataBase = new DataBase();
        }

        public int Save(T entity)
        {
            return _dataBase.Save(entity);
        }

        public T GetById(int id)
        {
            return _dataBase.GetById(id) as T;
        }
    }
}