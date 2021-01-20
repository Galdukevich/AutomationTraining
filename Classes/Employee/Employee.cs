using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class Employee : IWorkable
    {
        private string _firstName;
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value = "hello";
            }
        }
        public string LastName { get; set; }
        public float Salary { get; set; }

        public int[] Marks;

        public int this[int index]
        {
            get
            {
                return Marks[index];
            }
            set
            {
                Marks[index] = value;
            }
        }

        //public virtual string GetInfo()
        //{
        //   return FirstName + " " + LastName + " " + Salary;
        //}

        public abstract string GetInfo();

        public abstract void Work();

        public int[] PrintMassive(int[] PrintMassive)
        {
            for (int i = 0; i < PrintMassive.Length; i++)
            //foreach (int i in PrintMassive)
            {
                Console.WriteLine(PrintMassive[i]);
            }
            return PrintMassive;
        }

        public Employee(string fn, string ln, float sal, int[] mk)
        {
            FirstName = fn;
            LastName = ln;
            Salary = sal;
            Marks = mk;
        }

        public Employee()
        { }

        /*
        public void SetName(string NewName)
        {
                return;
        }
        public string GetFirstName(string password)
        {
            if (password == "12345")
            {
                return "Name = " + firstName;
            }
            else
            {
                return "No Information";
            }
        }
        public void SetLastName(string NewLastName)
        {           
                return;           
        }
        public string GetLastName(string password)
        {
            if (password == "12345")
            {
                return "Surname = " + lastName;
            }
            else
            {
                return "No Information";
            }
        }
        public float SetSalary(float NewSalary)
        {                      
                return NewSalary;                 
        }
        public float GetSalary(float NewSalary)
        {
            return NewSalary;
        }*/
    }
}
