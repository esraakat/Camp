using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("The customer was added: " + customer.customerName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("The customer was deleted: " + customer.customerName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("The customer was updated: " + customer.customerName);
        }
    }
}