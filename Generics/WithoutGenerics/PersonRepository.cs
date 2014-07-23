using System.Collections.Generic;
using WithoutGenerics.Entities;

namespace WithoutGenerics
{
    public class PersonRepository
    {
        private readonly DataBase _dataBase;

        public PersonRepository()
        {
            _dataBase = new DataBase();
        }

        public int Save(Person entity)
        {
            return _dataBase.Save(entity);
        }

        public Person GetById(int id)
        {
            var person = _dataBase.GetById(id) as Person;
            return person;
        }

        public IList<Person> GetAll
        {
            get
            {
                return _dataBase.GetAllPeople();
            }
        }
    }
}