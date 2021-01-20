using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    static class Helper
    {
        public static int Sum (this int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
                sum += mas[i];
            return sum;
        }

        public static string MasToString (this int[] mas)
        {
            string sum ="";
            for (int i = 0; i < mas.Length; i++)
                sum += mas[i];
            return sum;
        }

        public static string RemoveTags(this string inputString)
        {
            return "text";
        }
    }
}
