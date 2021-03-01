using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            //instansiate facade class
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("hesam darbandi");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}
