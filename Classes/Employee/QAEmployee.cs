using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class QAEmployee : Employee, IMeetingAttendable
    {
        public string Specialization { get; set; }

        public QAEmployee(string fn, string ln, float sal, int[] mk, string spec):base(fn, ln, sal, mk)
        {
            Specialization = spec;
        }
        public override string GetInfo()
        {
            return FirstName + ", " + LastName + ", " + Salary + ", " + Helper.MasToString(Marks) + ", " + Specialization;
        }
        public override void Work()
        {
            Console.WriteLine("QA working");
        }

        public void AttendMeeting()
        {
            throw new NotImplementedException();
        }
    }
}  

