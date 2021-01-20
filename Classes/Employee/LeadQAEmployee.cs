using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class LeadQAEmployee:QAEmployee, IJiraTaskCreatable
    {
        public LeadQAEmployee(string fn, string ln, float sal, int[] mk, string spec) : base(fn, ln, sal, mk, spec)
        {

        }

        public void CreateTask(string taskName)
        {
            Console.WriteLine("Task named {0} is created", taskName);
        }

        public override string GetInfo()
        {
            return FirstName + ", " + LastName + ", " + Salary + ", " + Helper.MasToString(Marks) + ", " + Specialization;
        }
        public override void Work()
        {
            Console.WriteLine("QA working");
        }
    }
}
