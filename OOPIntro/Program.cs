using System;
using System.Collections.Generic;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var sebClient = new Customer() 
            { 
                Forenames = "Zara", 
                Lastnames = "Lisecka"
            };

            var swedClient = new Customer()
            {
                Forenames = "Lina",
                Lastnames = "Verinci"
            };

            var bank1 = new Bank()
            {
                Name = "Seb",
                Customers = new List<Customer>()
                {
                    sebClient
                }
            }; 

            var bank2 = new Bank()
            {
                Name = "Swedbank",
                Customers = new List<Customer>()
                {
                    swedClient
                }
            };

            Console.WriteLine(bank1.GetInformation());
            Console.WriteLine(bank2.GetInformation());

            bank2.SetDeteled(true);

            // inaccessible due to protection level
            //bank2.Deleted = true;
        }
    }
}
