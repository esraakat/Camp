using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerId = 111;
            customer1.customerName = "Esra";
            customer1.customerSurname = "Akat";
            customer1.customerGender = "Female";
            customer1.customerCity = "İstanbul";

            Customer customer2 = new Customer();
            customer2.customerId = 222;
            customer2.customerName = "Ahmet";
            customer2.customerSurname = "Vural";
            customer2.customerGender = "Male";
            customer2.customerCity = "Ankara";

            Customer customer3 = new Customer();
            customer3.customerId = 333;
            customer3.customerName = "Ali";
            customer3.customerSurname = "Yılmaz";
            customer3.customerGender = "Male";
            customer3.customerCity = "İzmir";

            Customer customer4 = new Customer();
            customer4.customerId = 444;
            customer4.customerName = "Elif";
            customer4.customerSurname = "Şimşek";
            customer4.customerGender = "Female";
            customer4.customerCity = "Bursa";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.customerId + ": " + customer.customerName + " " +
                    customer.customerSurname + " " + customer.customerGender + " " + customer.customerCity);

                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(customer);
                customerManager.Delete(customer);
                customerManager.Update(customer);

                Console.WriteLine("-----------------------------\n");
            }
        }
    }
}
