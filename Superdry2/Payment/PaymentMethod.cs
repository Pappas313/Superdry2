using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Superdry2
{
    abstract class PaymentMethod
    {
        public abstract bool Pay(decimal amount);
    }

    class CreditCard : PaymentMethod
    {
        private bool _valid;
        public CreditCard()
        {
            _valid = CardInfo();
        }

        public override bool Pay(decimal amount)
        {
            if (_valid)
            {
                Console.WriteLine($"Proceeding to pay the amount of the {amount}€ using Card...");
                return _valid;
            }
            else
            {
                Console.WriteLine($"Cannot pay the amount of the {amount} using Card!");
                return _valid;
            }

        }

        private bool CardInfo()
        {
            Console.Write("Enter the card number: ");
            var id = CardNumValidation(Console.ReadLine().Trim());

            Console.Write("Enter the CCV: ");
            var ccv = CCVValidation(Console.ReadLine().Trim());

            Console.Write("Enter the expiration date (Month/Year): ");
            var exp = Input.ExpireInput();

            return id && exp && ccv;
        }
        private bool CardNumValidation(string id)
        {
            if (Regex.Replace(id, @"\s+", "").Length != 16)
            {
                return false;
            }
            return true;
        }

        private bool CCVValidation(string ccv)
        {
            return Regex.Match(ccv, @"^\d{3}$").Success;
        }
    }

    class BankTransfer : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            Console.Write("Enter the IBAN: ");
            string bankAccount = Console.ReadLine().ToUpper();

            if (String.IsNullOrEmpty(bankAccount))
            {
                Console.WriteLine("Invalid IBAN");
                return false;
            }
            else if (Regex.IsMatch(bankAccount, "^[A-Z0-9]"))
            {
                bankAccount = bankAccount.Replace(" ", String.Empty);
                string bank =
                bankAccount.Substring(4, bankAccount.Length - 4) + bankAccount.Substring(0, 4);
                int asciiShift = 55;
                StringBuilder sb = new StringBuilder();
                foreach (char c in bank)
                {
                    int v;
                    if (Char.IsLetter(c)) v = c - asciiShift;
                    else v = int.Parse(c.ToString());
                    sb.Append(v);
                }
                string checkSumString = sb.ToString();
                int checksum = int.Parse(checkSumString.Substring(0, 1));
                for (int i = 1; i < checkSumString.Length; i++)
                {
                    int v = int.Parse(checkSumString.Substring(i, 1));
                    checksum *= 10;
                    checksum += v;
                    checksum %= 97;
                }

                if (checksum == 1)
                {
                    Console.WriteLine("Payment Completed");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid IBAN");
                    return false;
                }
            }
            else
                Console.WriteLine("Invalid IBAN");
            return false;

        }
    }

    class Cash : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            Console.Write("Enter the money to pay (in euros): ");
            decimal paid = Decimal.Parse(Console.ReadLine().Trim());

            if (amount <= paid)
            {
                Console.WriteLine("Payment Completed");
                Console.WriteLine("You have {0}€ change", paid - amount);
                return true;
            }
            else
            {
                Console.WriteLine("Payment error!");
                Console.WriteLine("You paid less than the required amount.");
                return false;
            }

        }
    }

    class PaymentChoice
    {
        public void PayBasket(Basket basket)
        {

            switch (Menu.PaymentMethodMenu())
            {
                case 1:
                    basket.SelectPaymentMethod(new CreditCard());
                    break;

                case 2:
                    basket.SelectPaymentMethod(new BankTransfer());
                    break;

                case 3:
                    basket.SelectPaymentMethod(new Cash());
                    break;

            }
        }
    }
}
