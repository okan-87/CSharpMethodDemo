using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : " + customer.IdNumber);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : " + customer.IdNumber);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer informations updated : " + customer.IdNumber);
        }
    }
}
