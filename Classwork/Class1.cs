using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public static class Class1
    {
        public static TResult[] Transform<T, TResult>(this T[] data, Func<T, TResult> f)
        {
            var result = new TResult[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = f(data[i]);
            }
            return result;
        }
    }
}
