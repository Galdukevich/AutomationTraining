using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    class DevEmployee:Employee, IMeetingAttendable
    {
        public static int NumberOfCalls;

        public string ProgrammingLanguage { get; set; }

        public DevEmployee(string fn, string ln, float sal, int[] mk, string language) : base(fn, ln, sal, mk)
        {
            ProgrammingLanguage = language;
        }
        public override string GetInfo()
        {
            return FirstName + ", " + LastName + ", " + Salary + ", " + Helper.MasToString(Marks) + ", " + ProgrammingLanguage;
        }

        public override void Work()
        {
            Console.WriteLine("Dev working");
        }

        public void AttendMeeting()
        {
            throw new NotImplementedException();
        }
        public static void GetClassInfo()
        {
            NumberOfCalls++;
            Console.WriteLine("This is dev");
        }
    }
}
