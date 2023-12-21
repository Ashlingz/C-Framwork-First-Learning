using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MainProduct
    {
        static void Mainx()
        {
            int n;
            Console.Write("Enter Number of Product = ");
            n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for(int i = 0; i<n; i++)
            {
                Product product = new Product();
                Console.WriteLine();
                product.InputPro();
                products.Add(product);
                Console.WriteLine("_____________________________________");

            }
            Console.WriteLine("ID\tName\tPrice\tQty\tAmount");
            double total = 0;
                foreach(Product product in products)
            {
                Console.WriteLine(product);
                total += product.Amount();

            }
            Console.WriteLine("_____________________________________");
            Console.WriteLine($"Total Amount = {total:c2}");
            Console.ReadKey();

        }
    }
}
