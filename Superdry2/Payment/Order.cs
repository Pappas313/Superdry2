using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2
{
    class Order
    {
        public void BuyTShirt(TShirt tshirt)
        {
            var amount = Convert.ToDecimal(new ColorVariation().AddCost(tshirt));
            amount += Convert.ToDecimal(new SizeVariation().AddCost(tshirt));
            amount += Convert.ToDecimal(new BrandVariation().AddCost(tshirt));

            var basket = new Basket();
            basket.SetDueAmount(amount);

            var pay = new PaymentChoice();
            pay.PayBasket(basket);



            if (basket.Pay())
            {
                Console.WriteLine("Purchase completed!");
            }
            else
            {
                Console.WriteLine("Purchase cancelled!");
            }


        }
    }

    class Basket
    {
        private PaymentMethod _paymentMethod;
        private decimal _amount;

        public void SelectPaymentMethod(PaymentMethod paymentMethod)
        {

            _paymentMethod = paymentMethod;
        }

        public void SetDueAmount(decimal amount)
        {
            _amount = amount;
            Console.WriteLine("The price of this product is: {0}€", amount);
        }

        public bool Pay()
        {

            return _paymentMethod.Pay(_amount);
        }
    }


}