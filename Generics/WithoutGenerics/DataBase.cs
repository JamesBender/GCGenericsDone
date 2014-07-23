using System.Collections.Generic;
using WithoutGenerics.Entities;

namespace WithoutGenerics
{
    public class DataBase
    {
        public int Save(Entity entity)
        {
            var personType = typeof (Person);
            var companyType = typeof (Company);
            
            if (personType.IsInstanceOfType(entity))
            {
                return 1;
            }
            
            if (companyType.IsInstanceOfType(entity))
            {
                return 2;
            }

            return 3;
            
        }

        public object GetById(int id)
        {
            switch (id)
            {
                case 1:
                    return new Person {Id = 1, FirstName = "John", LastName="Doe"};
                case 2:
                    return new Company {Id = 2, CompanyName = "Acme Co."};
                default:
                    return new Order {Id = 3, OrderTotal = 124.45};
            }            
        }

        public IList<Person> GetAllPeople()
        {
            return new List<Person>();
        }

        public IList<Company> GetAllCompanies()
        {
            return new List<Company>();
        }

        public IList<Order> GetAllOrder()
        {
            return new List<Order>();
        }
    }
}