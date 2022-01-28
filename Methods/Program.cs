using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "Elma";
            product1.price = 15;
            product1.details = "Amasya elması";

            Product product2 = new Product();
            product2.productId = 2;
            product2.productName = "Karpuz";
            product2.price = 80;
            product2.details = "Diyarbakır karpuzu";

            Product product3 = new Product();
            product3.productId = 3;
            product3.productName = "Patates";
            product3.price = 20;
            product3.details = "Afyonkarahisar patatesi";

            Product[] products = new Product[] {product1, product2, product3};

            foreach (Product product in products)
            {
                Console.WriteLine(product.productName + " \n" + product.details + " : " + product.price);
                Console.WriteLine();
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Remove(product1);

        }
    }
}
