using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Superdry2
{
    class Program
    {
        static void Main(string[] args)
        {

            Superdry2();

            Console.ReadKey();
        }

        static void Project3()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Create your T-Shirt");
            Console.WriteLine();

            
            TShirt tshirt = new TShirt(
                Menu.ColourChoice(),
                Menu.SizeChoice(),
                Menu.BrandChoice()
                );



            Order order = new Order();
            order.BuyTShirt(tshirt);
        }

        static void Superdry2()
        {
            var data = new Data();

            Menu.ShorterChoice(data.tshirts);
        }

    }
}
