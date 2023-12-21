using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
 internal class Product
 {
        public int id;
        public string name;
        public double price;
        public int qty;
         public double Amount()
         {
            return price * qty;

         }

        public Product()
        {

        }

        public Product(int id, string name, double price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
        }
        public override string ToString()
        {
            return $"{id:000}\t{name}\t{price:c2}\t{qty}\t{Amount():c2}";
        }
        public void InputPro()
        {
            Console.Write("Enter ID     =");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name   =");
            name = Console.ReadLine();
            Console.Write("Enter Price  =");
            price = double.Parse(Console.ReadLine());
            Console.Write("Enter QTY    =");
            qty = int.Parse(Console.ReadLine());
            Console.WriteLine($"Amount  ={Amount():c2}");
            
 

     
        }
        
 }
}
