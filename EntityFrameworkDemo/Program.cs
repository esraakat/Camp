using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //.net içerisinde ADO.NET var. Veritsbsnıns bağlanmamızı , orada sorgu yazmamızı sağlayan bir kütüphane. Bununla yazdığımız kodlar yorucu
            //O yuzden çeşitli ORM yapıları kullanırız - Object Relational Mapping
            //Entity Framework bir orm - NHibernate onun bir alternatifidir.

            GetAll();



        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsyCategory(int id)
        {
            NorthwindContext context = new NorthwindContext();

            var result = context.Products.Where(p => p.CategoryId == id);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

    }
}
