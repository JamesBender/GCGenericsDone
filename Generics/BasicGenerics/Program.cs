using System;
using BasicGenerics.Entities;
using BasicGenerics.WithoutGenerics;

namespace BasicGenerics
{
    class Program
    {
        static void Main()
        {
            //Create all the repos I need
            var personRepo = new Repository<Person>();
            var companyRepo = new Repository<Company>();
            var orderRepo = new Repository<Order>();

            //Get some entities
            var person = personRepo.GetById(1);
            var company = companyRepo.GetById(2);
            var order = orderRepo.GetById(3);

            //Chagne and save entities
            person.FirstName = "Bob";
            company.CompanyName = "Bob's House of Propane and Day Old Sushi";
            order.OrderTotal = 1000000;

            var personId = personRepo.Save(person);
            var companyId = companyRepo.Save(company);
            var orderId = orderRepo.Save(order);

            Console.WriteLine("Saved person, Id is {0}", personId);
            Console.WriteLine("Saved company, Id is {0}", companyId);
            Console.WriteLine("Saved order, Id is {0}", orderId);

            Console.ReadKey();            
        }
    }
}
