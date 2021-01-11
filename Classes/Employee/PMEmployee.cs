﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class PMEmployee:Employee, IJiraTaskCreatable, IMeetingAttendable
    {
        public string ManagingProject { get; set; }

        public PMEmployee(string fn, string ln, float sal, string projectName) : base(fn, ln, sal)
        {
            ManagingProject = projectName;
        }
        public override string GetInfo()
        {
            return FirstName + " " + LastName + " " + Salary + " " + ManagingProject;
        }

        public override void Work()
        {
            Console.WriteLine("PM working");
        }

        public void CreateTask(string taskName)
        {
            Console.WriteLine("PM has created task named {0}", taskName);
        }

        public void AttendMeeting()
        {
            throw new NotImplementedException();
        }
    }
}

