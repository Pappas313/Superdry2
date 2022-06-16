using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2
{
    class TShirt
    {
        public readonly Color Color;
        public readonly Size Size;
        public readonly Brand Brand;

        public decimal Price { get; set; }

        public TShirt(Color color, Size size, Brand Brand)
        {
            Color = color;
            Size = size;
            Brand = Brand;

        }

        public void Print()
        {

            Console.WriteLine("{0} TShirt, Size: {1}, Made by {2}", Color, Size, Brand);

        }
    }

    enum Color { BLUE, GREEN, INDIGO, ORANGE, RED, VIOLET, YELLOW }
    enum Size { XS, S, M, L, XL, XXL, XXXL }
    enum Brand { WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }


}