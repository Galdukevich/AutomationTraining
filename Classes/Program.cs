using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<char> listInt = new MyList<char>();
            listInt.AddHead(1);
            listInt.AddHead(2);
            listInt.AddHead(3);

            //create employes massive with 3 employee objects
            Employee employee1 = new PMEmployee("firstName1", "lastName1", 1000, "NoProject");
            PMEmployee employee2 = new PMEmployee("firstName1", "lastName1", 1000, "Wex");
            DevEmployee employee3 = new DevEmployee("firstName1", "lastName1", 1000, "C#");
            QAEmployee qaemployee = new QAEmployee("QaName", "QaSurname", 1500f, "WEB");
            VacuumCleaner cleaner = new VacuumCleaner("Samsung");
            LeadQAEmployee leadqaemployee = new LeadQAEmployee("QaName", "QaSurname", 1500f, "Lead");

            /*IWorkable[] employes = new IWorkable[] { employee1, employee2, employee3, qaemployee, cleaner, leadqaemployee};*/

            List<IWorkable> employes = new List<IWorkable>();
            employes.Add(employee1);
            employes.Add(employee2);
            employes.Add(employee3);
            employes.Add(qaemployee);
            employes.Add(cleaner);
            employes.Add(leadqaemployee);

            //initialize employees
            employee3.FirstName = "firstName3";
            qaemployee.FirstName = "QAFirstName";
            qaemployee.Specialization = "Automation";
            cleaner.Producer = "Xiaomi";
            //Console.WriteLine(cleaner.GetInfo());
            //Console.ReadKey();

            foreach (IWorkable employee in employes)
            {
            Console.WriteLine(employee.GetInfo());           
            }
            foreach(IWorkable worker in employes)
            {
                if(worker is IJiraTaskCreatable)
                {
                    IJiraTaskCreatable taskCreator = (IJiraTaskCreatable)worker;
                    //CreateTask(taskCreator, "info");
                    taskCreator.CreateTask("Task1");
                    
                    //(worker as IJiraTaskCreatable).CreateTask("Task1");
                }
                if (worker is PMEmployee)
                {
                    PMEmployee pm = (PMEmployee)worker;
                    Console.WriteLine(pm.ManagingProject);
                    Console.ReadKey();
                }
            }
        }
        //static void CreateTask(IJiraTaskCreatable creator, string info)
        //{
        //    creator.CreateTask(info)
        //}
    }
}
