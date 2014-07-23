using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create all the repos I need
            var personRepo = new PersonRepository();
            var companyRepo = new CompanyRepository();
            var orderRepo = new OrderRepository();

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
