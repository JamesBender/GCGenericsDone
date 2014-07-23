using System;
using MethodLevelGenerics.Entities;

namespace MethodLevelGenerics
{
    class Program
    {
        static void Main()
        {
            //Create all the repos I need
            var repo = new Repository();
            
            //Get some entities
            var person = repo.GetById<Person>(1);
            var company = repo.GetById<Company>(2);
            var order = repo.GetById<Order>(3);

            //Chagne and save entities
            person.FirstName = "Bob";
            company.CompanyName = "Bob's House of Propane and Day Old Sushi";
            order.OrderTotal = 1000000;

            var personId = repo.Save(person);
            var companyId = repo.Save(company);
            var orderId = repo.Save(order);

            Console.WriteLine("Saved person, Id is {0}", personId);
            Console.WriteLine("Saved company, Id is {0}", companyId);
            Console.WriteLine("Saved order, Id is {0}", orderId);

            Console.ReadKey();            
        }
    }
}
