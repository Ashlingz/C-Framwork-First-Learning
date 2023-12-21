using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SubProduct
    {
     
        public static void ShowAllProduct(List<Product> ls)
        {
            Console.WriteLine("ID\tName\tPrice\tQty/tAmount");
            double totalAmount = 0;
            foreach(Product p in ls)
    {
                Console.WriteLine(p);
                totalAmount += p.Amount();
            }
            Console.WriteLine($"\t\tTotalAmount ={totalAmount:c2}");
        }

        public static void AddProducts(List<Product> ls)
        {
            int n;
            Console.Write("Enter Amount to Add = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Product p = new Product();
                p.InputPro();
                ls.Add(p);
            }
        }
        public static int CheckID(List<Product> ls,int id)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].id == id)
                    return i;
            }
            return -1;
        }

        public static void RemoveProduct(List<Product> ls)
        {
            ShowAllProduct(ls);
            int id;
            Console.Write("Enter ID to Remove = ");
            id = int.Parse(Console.ReadLine());
            int index = CheckID(ls, id);
            if (index == -1)
            {
                Console.WriteLine("ID Not Found");
            }
            else
            {
                Product p = ls[index];
                Console.WriteLine("This Have Been Remove");
                Console.WriteLine(p);
                ls.RemoveAt(index);
            }

        }

        public static void EditProducts(List<Product> ls)
        {
            ShowAllProduct(ls);
            int id;
            Console.Write("Enter ID to Edit = ");
            id = int.Parse(Console.ReadLine());
            int index = CheckID(ls, id);
            if (index == -1)
            {
                Console.WriteLine("ID Not Found");
            }
            else
            {
                Console.WriteLine("");
                Product p = ls[index];
                Console.WriteLine(p);
                Console.WriteLine("ID=" + p.id);
                Console.Write("Enter Name =");
                p.name = Console.ReadLine();
                Console.Write("Enter Price =$");
                p.price = double.Parse( Console.ReadLine());
                Console.Write("Enter QTY=");
                p.qty = int.Parse(Console.ReadLine());
                Console.WriteLine($"Amount ={p.Amount():c2}");

            }
        }
        public static int Board()
        {
            Console.WriteLine("Press 1 to Show Product");
            Console.WriteLine("Press 2 to Add Product");
            Console.WriteLine("Press 3 to Remove SubProduct.");
            Console.WriteLine("Press 4 to Edit Product");
            Console.WriteLine("Press 5 to Exit");

            int num;
            do
            {
                Console.Write("Please Press The Menu Number to Access =");
                num = int.Parse(Console.ReadLine());

            } while (!(num >= 1 && num <= 5));
            return num;

        }


    }

}
