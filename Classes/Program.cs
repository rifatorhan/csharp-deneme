using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Rıfat";
            customer.LastName = "Orhan";
            customer.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2, 
                City = "İstanbul",
                FirstName = "Rıfat",
                LastName = "Orhan"
            };
            Console.WriteLine(customer2.LastName);
            Console.ReadLine();
        }
    }
}
