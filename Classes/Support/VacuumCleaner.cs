using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class VacuumCleaner: IWorkable
    {
        public string Producer { get; set; }
        public VacuumCleaner(string producer)
        {
            Producer = producer;
        }
        public string GetInfo()
        {
            return "I am " + Producer;
        }

        public void Work()
        {
            Console.WriteLine("VacuumCleaner working");
        }
    }
}
