using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2
{
    abstract class Variation
    {
        public abstract decimal AddCost(TShirt tshirt);
    }

    class ColorVariation : Variation
    {
        private static Dictionary<Color, decimal> _ColorPrice = new Dictionary<Color, decimal>()
            {
               {Color.RED, 7m },
               {Color.ORANGE, 4m },
               {Color.YELLOW, 2m },
               {Color.GREEN, 13m },
               {Color.BLUE, 6m },
               {Color.INDIGO, 10m },
               {Color.VIOLET, 8m }
            };
        public override decimal AddCost(TShirt tshirt)
        {
            tshirt.Price = _ColorPrice[tshirt.Color];
            return tshirt.Price;
        }
    }

    class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _SizePrice = new Dictionary<Size, decimal>()
            {
                { Size.XS, 2.0m },
                { Size.S, 3.5m },
                { Size.M, 3.0m },
                { Size.L, 4.2m },
                { Size.XL, 5.4m },
                { Size.XXL, 6.9m },
                { Size.XXXL, 10.0m }
            };

        public override decimal AddCost(TShirt tshirt)
        {
            tshirt.Price = _SizePrice[tshirt.Size];
            return tshirt.Price;
        }
    }

    class BrandVariation : Variation
    {
        private static Dictionary<Brand, decimal> _BrandPrice = new Dictionary<Brand, decimal>()
            {
                { Brand.CASHMERE, 14m },
                { Brand.COTTON, 20m },
                { Brand.LINEN, 24m },
                { Brand.POLYESTER, 4m },
                { Brand.RAYON, 9m },
                { Brand.SILK, 50m },
                { Brand.WOOL, 23m }
            };

        public override decimal AddCost(TShirt tshirt)
        {
            tshirt.Price = _BrandPrice[tshirt.Brand];
            return tshirt.Price;
        }
    }
}
