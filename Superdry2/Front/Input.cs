using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2
{
    internal static class Input
    {
        /// <summary>
        /// Value input for integer purposes
        /// </summary>
        /// <returns></returns>
        internal static int IntInput()
        {
            string input = Console.ReadLine();
            int output;

            while (!int.TryParse(input, out output))
            {

                try
                {
                    output = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You inserted an invalid number!");


                }
                catch (OverflowException)
                {
                    Console.WriteLine("You inserted a very long number!");
                }
                Console.Write("Enter a valid integer number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        internal static DateTime DateInput()
        {
            string date = Console.ReadLine();
            DateTime correctDate;
            while (!DateTime.TryParseExact(date, "M/yyyy", null, System.Globalization.DateTimeStyles.None, out correctDate))
            {
                Console.WriteLine("Invalid data input!");
                Console.Write("The date must be written like \"Month / Year\"): ");
                date = Console.ReadLine();
            }
            return correctDate;
        }

        /// <summary>
        /// Value input to check valid expiration date.
        /// </summary>
        /// <returns></returns>
        internal static bool ExpireInput()
        {
            DateTime input = DateInput();
            if (input <= DateTime.Now)
            {
                Console.WriteLine("The card is expired!!");
                return false;
            }
            return true;
        }


    }
}
