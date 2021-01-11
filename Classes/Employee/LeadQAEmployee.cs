using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class LeadQAEmployee:QAEmployee, IJiraTaskCreatable
    {
        public LeadQAEmployee(string fn, string ln, float sal, string spec) : base(fn, ln, sal, spec)
        {

        }

        public void CreateTask(string taskName)
        {
            Console.WriteLine("Task named {0} is created", taskName);
        }

        public override string GetInfo()
        {
            return FirstName + " " + LastName + " " + Salary + " " + Specialization;
        }
        public override void Work()
        {
            Console.WriteLine("QA working");
        }
    }
}
