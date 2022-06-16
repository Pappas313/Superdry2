using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Superdry2.Methods;

namespace Superdry2
{
    static class Menu
    {
        public static Color ColourChoice()
        {
            //{ RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET }
            int choice;

            do
            {
                Console.WriteLine("Enter the related number for the preffered color: ");
                Console.WriteLine("1: RED");
                Console.WriteLine("2: ORANGE");
                Console.WriteLine("3: YELLOW");
                Console.WriteLine("4: GREEN");
                Console.WriteLine("5: BLUE");
                Console.WriteLine("6: INDIGO");
                Console.WriteLine("7: VIOLET");
                Console.Write("-------------> ");
                choice = Input.IntInput();

            } while (choice < 1 || choice > 7);


            switch (choice)
            {
                case 1:
                    return Color.RED;
                case 2:
                    return Color.ORANGE;
                case 3:
                    return Color.YELLOW;
                case 4:
                    return Color.GREEN;
                case 5:
                    return Color.BLUE;
                case 6:
                    return Color.INDIGO;
                case 7:
                    return Color.VIOLET;
                default:
                    return Color.BLUE;


            }

        }

        public static Size SizeChoice()
        {
            //{ XS, S, M, L, XL, XXL, XXXL }
            int choice;

            do
            {
                Console.WriteLine("Enter  number for the size: ");
                Console.WriteLine("1: XS");
                Console.WriteLine("2: S");
                Console.WriteLine("3: M");
                Console.WriteLine("4: L");
                Console.WriteLine("5: XL");
                Console.WriteLine("6: XXL");
                Console.WriteLine("7: XXXL");
                Console.Write("-------------> ");
                choice = Input.IntInput();

            } while (choice < 1 || choice > 7);


            switch (choice)
            {
                case 1:
                    return Size.XS;
                case 2:
                    return Size.S;
                case 3:
                    return Size.M;
                case 4:
                    return Size.L;
                case 5:
                    return Size.XL;
                case 6:
                    return Size.XXL;
                case 7:
                    return Size.XXXL;
                default:
                    return Size.M;


            }

        }
        public static Brand BrandChoice()
        {
            //{ WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }            
            int choice;

            do
            {
                Console.WriteLine("Enter  number for  material: ");
                Console.WriteLine("1: WOOL");
                Console.WriteLine("2: COTTON");
                Console.WriteLine("3: POLYESTER");
                Console.WriteLine("4: RAYON");
                Console.WriteLine("5: LINEN");
                Console.WriteLine("6: CASHMERE");
                Console.WriteLine("7: SILK");
                Console.Write("-------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 7);


            switch (choice)
            {
                case 1:
                    return Brand.WOOL;
                case 2:
                    return Brand.COTTON;
                case 3:
                    return Brand.POLYESTER;
                case 4:
                    return Brand.RAYON;
                case 5:
                    return Brand.LINEN;
                case 6:
                    return Brand.CASHMERE;
                case 7:
                    return Brand.SILK;
                default:
                    return Brand.COTTON;


            }

        }

        public static int PaymentMethodMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("Give number for payment? ");
                Console.WriteLine("1: Credit/Debit Card");
                Console.WriteLine("2: Bank Transfer");
                Console.WriteLine("3: Cash");
                Console.Write("-------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 3);



            return choice;
        }







      
        public static void ShorterChoice(List<TShirt> shirts)
        {
            int choice;

            do
            {
                Console.WriteLine("Which type of sorting do you want to use?");
                Console.WriteLine("1: Bublet");
                Console.WriteLine("2: Quick");
                Console.WriteLine("3: Bucket");
                Console.Write("-------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 3);

            switch (choice)
            {
                case 1:
                    BubleChoice(shirts);
                    break;
                case 2:
                    QuickChoice(shirts.ToArray());
                    break;
                case 3:
                    BucketChoice(shirts);
                    break;

            }


        }

        private static void BubleChoice(List<TShirt> shirts)
        {
            int choice;

            do
            {
                Console.WriteLine("Enter the related number for the preffered shorting: ");
                Console.WriteLine("1. Size in ascending");
                Console.WriteLine("2. Size in descending");
                Console.WriteLine("3. Color in ascending");
                Console.WriteLine("4. Color in descending");
                Console.WriteLine("5. Brand in ascending");
                Console.WriteLine("6. Brand in descending");
                Console.WriteLine("7. Size and Color and Brand in ascending");
                Console.WriteLine("8. Size and Color and Brand in descending");
                Console.Write("-------------------------------------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 8);

            switch (choice)
            {
                case 1:
                    Buble.SizeAsc(shirts);
                    break;
                case 2:
                    Buble.SizeDesc(shirts);
                    break;
                case 3:
                    Buble.ColorAsc(shirts);
                    break;
                case 4:
                    Buble.ColorDesc(shirts);
                    break;
                case 5:
                    Buble.BrandAsc(shirts);
                    break;
                case 6:
                    Buble.BrandDesc(shirts);
                    break;
                case 7:
                    Buble.SizeColorBrandAsc(shirts);
                    break;
                case 8:
                    Buble.SizeColorBrandDesc(shirts);
                    break;
                default:
                    break;
            }
            foreach (var item in shirts)
            {
                item.Print();
            }
        }
        private static void BucketChoice(List<TShirt> shirts)
        {
            int choice;

            do
            {
                Console.WriteLine("Enter the related number for the preffered shorting: ");
                Console.WriteLine("1. Size ascending");
                Console.WriteLine("2. Size  descending");
                Console.WriteLine("3. Color  ascending");
                Console.WriteLine("4. Color descending");
                Console.WriteLine("5. Brand ascending");
                Console.WriteLine("6. Brand  descending");
                Console.WriteLine("7. Size and Color and Brand in ascending");
                Console.WriteLine("8. Size and Color and Brand in descending");
                Console.Write("-------------------------------------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 8);

            switch (choice)
            {
                case 1:
                    shirts = Bucket.SizeAsc(shirts);
                    break;
                case 2:
                    //shirts = Bucket.SizeDesc(shirts);
                    break;
                case 3:
                    shirts = Bucket.ColorAsc(shirts);
                    break;
                case 4:
                    shirts = Bucket.ColorDesc(shirts);
                    break;
                case 5:
                    shirts = Bucket.BrandAsc(shirts);
                    break;
                case 6:
                    //shirts = Bucket.BrandDesc(shirts);
                    break;
                case 7:
                    //shirts = Bucket.SizeColorBrandAsc(shirts);
                    break;
                case 8:
                    //shirts = Bucket.SizeColorBrandDesc(shirts);
                    break;
                default:
                    break;
            }
            foreach (var item in shirts)
            {
                item.Print();
            }
        }
        private static void QuickChoice(TShirt[] shirts)
        {
            int choice;

            do
            {
                Console.WriteLine("Enter the related number for the preffered shorting: ");
                Console.WriteLine("1. Size ascending");
                Console.WriteLine("2. Size  descending");
                Console.WriteLine("3. Color  ascending");
                Console.WriteLine("4. Color  descending");
                Console.WriteLine("5. Brand  ascending");
                Console.WriteLine("6. Brand descending");
                Console.WriteLine("7. Size and Color and Brand in ascending");
                Console.WriteLine("8. Size and Color and Brand in descending");
                Console.Write("-------------------------------------------> ");

                choice = Input.IntInput();

            } while (choice < 1 || choice > 8);

            switch (choice)
            {
                case 1:
                    Quick.SizeAsc(shirts);
                    break;
                case 2:
                    Quick.SizeDesc(shirts);
                    break;
                case 3:
                    Quick.ColorAsc(shirts);
                    break;
                case 4:
                    Quick.ColorDesc(shirts);
                    break;
                case 5:
                    Quick.BrandAsc(shirts);
                    break;
                case 6:
                    Quick.BrandDesc(shirts);
                    break;
                case 7:
                    Quick.SizeColorBrandAsc(shirts);
                    break;
                case 8:
                    Quick.SizeColorBrandDesc(shirts);
                    break;
                default:
                    break;
            }
            foreach (var item in shirts)
            {
                item.Print();
            }
        }

    }
}
