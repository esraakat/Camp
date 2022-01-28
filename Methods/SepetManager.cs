using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("The product was added: " + product.productName);
        }

        public void Remove(Product product)
        {
            Console.WriteLine("The product was removed: " + product.productName);
        }
    }
}
