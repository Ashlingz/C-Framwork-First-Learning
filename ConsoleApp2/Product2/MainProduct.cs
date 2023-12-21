using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MenuProduct
    {
        static void Main()
        {
            List<Product> ls = new List<Product>();
            BACK:
            Console.Clear();
            int menu = SubProduct.Board();
            switch (menu)
           
            {
                case 1:
                    SubProduct.ShowAllProduct(ls);
                    break;
                case 2:
                    SubProduct.AddProducts(ls);
                    break;
                case 3:
                    SubProduct.RemoveProduct(ls);
                    break;
                case 4:
                    SubProduct.EditProducts(ls);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            
            goto BACK;
        }
          

            

        
    }
}
