using System;

namespace ClassExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "Skirt";
            product1.price = 149.99;
            product1.stock = 10;


            Product product2 = new Product();
            product2.productId = 2;
            product2.productName = "Shoes";
            product2.price = 450.99;
            product2.stock = 5;

            Product product3 = new Product();
            product3.productId = 3;
            product3.productName = "T-shirt";
            product3.price = 99.99;
            product3.stock = 7;

            Product[] products = new Product[] { product1, product2, product3 };

            int i = 0;
            while(i < products.Length){
                Console.WriteLine(products[i].productId + " - " + products[i].productName + " : " + products[i].price);
                i++;
            }

            Console.WriteLine("\n--------While loop ended----------\n");

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine(products[j].productId + " - " + products[j].productName + " : " + products[j].price);
            }

            Console.WriteLine("\n----------For loop ended--------\n");

            foreach (Product product in products)
            {
                Console.WriteLine(product.productId + " - " + product.productName + " : " + product.price);
            }

            Console.WriteLine("\n----------Foreach loop ended--------\n");
        }
        
    }
}


class Product
{
    public int productId { get; set; }
    public string productName { get; set; }
    public double price { get; set; }
    public int stock { get; set; }
}
