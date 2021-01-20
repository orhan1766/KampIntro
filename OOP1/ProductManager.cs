using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("{0} ürünü eklendi",product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("{0} ürünü güncellendi", product.ProductName);
        }

    }
}
