using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry2.Methods
{
    static class Buble
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


        public static void BrandAsc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Brand > shirts[i + 1].Brand)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }


        public static void BrandDesc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Brand < shirts[i + 1].Brand)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

        }

        public static void ColorAsc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Color > shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

        }


        public static void ColorDesc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Color < shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

        }

        public static void SizeAsc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

        }


        public static void SizeDesc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

        }
    }
}
