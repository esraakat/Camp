using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Esra";
            customer1.Surname = "Akat";
            customer1.CustomerNumber = "12345";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.CustomerNumber = "54321";
            customer2.TaxNumber = "112233";


            Customer customer3 = new IndividualCustomer();
            customer3.Id = 3;
            customer3.CustomerNumber = "159430";

            Customer customer4 = new CorporateCustomer();
            customer4.Id = 4;
            customer4.CustomerNumber = "562152";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            foreach (Customer customer in customers)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(customer);
            }

        }
    }
}
