using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2.Methods
{
    static class Quick
    {
        //Partitions-------------------------------------------------------------------
        private static int ColorAscPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Color < pivot.Color)  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        private static int SizeAscPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Size < pivot.Size)  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        private static int BrandAscPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Brand < pivot.Brand)  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        private static int ColorDescPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Color > pivot.Color)  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        private static int SizeDescPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Size > pivot.Size)  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        private static int BrandDescPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].Brand > pivot.Brand)  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        //*****************************************************************************

        //Recursive Methods-----------------------------------------------------------

        private static void ColorAscRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = ColorAscPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorAscRecursive(arr, low, pi - 1);
                ColorAscRecursive(arr, pi + 1, high);
            }
        }
        private static void SizeAscRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = SizeAscPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeAscRecursive(arr, low, pi - 1);
                SizeAscRecursive(arr, pi + 1, high);
            }
        }
        private static void ColorDescRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = ColorDescPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorDescRecursive(arr, low, pi - 1);
                ColorDescRecursive(arr, pi + 1, high);
            }
        }
        private static void SizeDescRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = SizeDescPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeDescRecursive(arr, low, pi - 1);
                SizeDescRecursive(arr, pi + 1, high);
            }
        }
        private static void BrandAscRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = BrandAscPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                BrandAscRecursive(arr, low, pi - 1);
                BrandAscRecursive(arr, pi + 1, high);
            }
        }
        private static void BrandDescRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = BrandDescPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                BrandDescRecursive(arr, low, pi - 1);
                BrandDescRecursive(arr, pi + 1, high);
            }
        }

        //*******************************************************************************

        //Shorting Categories------------------------------------------------------------
        public static void BrandAsc(TShirt[] shirts)
        {
            BrandAscRecursive(shirts, 0, shirts.Length - 1);
        }
        public static void BrandDesc(TShirt[] shirts)
        {
            BrandDescRecursive(shirts, 0, shirts.Length - 1);
        }
        public static void ColorAsc(TShirt[] shirts)
        {
            ColorAscRecursive(shirts, 0, shirts.Length - 1);
        }
        public static void ColorDesc(TShirt[] shirts)
        {
            ColorDescRecursive(shirts, 0, shirts.Length - 1);
        }
        public static void SizeAsc(TShirt[] shirts)
        {
            SizeAscRecursive(shirts, 0, shirts.Length - 1);
        }
        public static void SizeDesc(TShirt[] shirts)
        {
            SizeDescRecursive(shirts, 0, shirts.Length - 1);
        }
        public static void SizeColorBrandAsc(TShirt[] shirts)
        {

            //Under Construction
            //ColorAsc(shirts);
            //SizeAsc(shirts);
            //BrandAsc(shirts);
        }
        public static void SizeColorBrandDesc(TShirt[] shirts)
        {
            //Under Construction
            //BrandDesc(shirts);
            //ColorDesc(shirts);
            //SizeDesc(shirts);

        }
        //*********************************************************************************
    }
}
