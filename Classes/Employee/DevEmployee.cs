using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    class DevEmployee:Employee, IMeetingAttendable
    {
        public string ProgrammingLanguage { get; set; }

        public DevEmployee(string fn, string ln, float sal, string language) : base(fn, ln, sal)
        {
            ProgrammingLanguage = language;
        }
        public override string GetInfo()
        {
            return FirstName + " " + LastName + " " + Salary + " " + ProgrammingLanguage;
        }

        public override void Work()
        {
            Console.WriteLine("Dev working");
        }

        public void AttendMeeting()
        {
            throw new NotImplementedException();
        }
    }
}
