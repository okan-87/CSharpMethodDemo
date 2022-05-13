using System;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.IdNumber = "11111";
            customer.FirstName = "Okan";
            customer.LastName = "Kaplan";
            customer.city = "Haarlem";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.IdNumber = "11112";
            customer2.FirstName = "Yigit";
            customer2.LastName = "Kaplan";
            customer2.city = "Ankara";

            CustomerManager manager = new CustomerManager();
            manager.Add(customer);
            manager.Add(customer2);

            Customer[] customers = new Customer[] { customer, customer2 };
            foreach (var item in customers)
            {
                Console.WriteLine("You are valuable to us : " + item.FirstName);
            }
        }
    }
}
