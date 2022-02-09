using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 5000;
            product1.UnitInStock = 10;

            Product product2 = new Product { Id = 2, CategoryId = 2, ProductName = "Blgisayar", 
                UnitPrice = 9999, UnitInStock = 5 };

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                ProductManager productManager = new ProductManager();
                productManager.Add(product);
                productManager.Update(product);
                productManager.Delete(product);
                Console.WriteLine("-----------------------");
            }
        }
    }
}
