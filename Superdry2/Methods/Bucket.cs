using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2.Methods
{
    static class Bucket
    {
        public static void SizeColorBrandAsc(List<TShirt> shirts)
        {
            BrandAsc(shirts);
            ColorAsc(shirts);
            SizeAsc(shirts);
        }
        public static void SizeColorBrandDesc(List<TShirt> shirts)
        {
            BrandDesc(shirts);
            ColorDesc(shirts);
            SizeDesc(shirts);
        }

        public static List<TShirt> BrandAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfBrands = Enum.GetValues(typeof(Brand)).Length;

            //Δημιουργώ τα buckets όσα είναι και τα χρώμματα (numOfBrands)
            List<TShirt>[] buckets = new List<TShirt>[numOfBrands];
            for (int i = 0; i < numOfBrands; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Brand;
                buckets[bucket].Add(shirts[i]);
                //buckets[numOfBrands].Add(shirts[i]);              //Φθείνουσα ταξινόμιση  
            }


            for (int i = 0; i < numOfBrands; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;


        }


        public static void BrandDesc(List<TShirt> shirts)
        {


        }

        public static List<TShirt> ColorAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfColors = Enum.GetValues(typeof(Color)).Length;

            //Δημιουργώ τα buckets όσα είναι και τα χρώμματα (numOfColors)
            List<TShirt>[] buckets = new List<TShirt>[numOfColors];
            for (int i = 0; i < numOfColors; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Color;
                buckets[bucket].Add(shirts[i]);
                //buckets[numOfColors].Add(shirts[i]);              //Φθείνουσα ταξινόμιση  
            }


            for (int i = 0; i < numOfColors; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;


        }


        public static List<TShirt> ColorDesc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfColors = Enum.GetValues(typeof(Color)).Length;


            List<TShirt>[] buckets = new List<TShirt>[numOfColors];
            for (int i = 0; i < numOfColors; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Color;
                buckets[bucket].Add(shirts[i]);
                //buckets[numOfColors].Add(shirts[i]);              //Φθείνουσα ταξινόμιση  
            }


            for (int i = 0; i < numOfColors; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;


        }

        public static List<TShirt> SizeAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfSizes = Enum.GetValues(typeof(Size)).Length;

            List<TShirt>[] buckets = new List<TShirt>[numOfSizes];
            for (int i = 0; i < numOfSizes; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Size;
                buckets[bucket].Add(shirts[i]);
               
            }

            for (int i = 0; i < numOfSizes; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;


        }


        public static void SizeDesc(List<TShirt> shirts)
        {


        }

    }
}
