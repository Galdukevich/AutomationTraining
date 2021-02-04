using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5 };

            var result = data.Transform(x => x * 2)           //return int massive {2, 4, 6, 8, 10}
                             .Transform(y => y > 5)           //return boolen (true | false) {false, false, true, true, true}
                             .Transform(x => x.ToString());   //massive true false converted to string {"false", "false", "true", "true", "true"}
        }
    }
}