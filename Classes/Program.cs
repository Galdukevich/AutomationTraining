using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        //OXadFF (adress)        
        public static int AddTwo(int data)
        {
            return data + 2;
        }
        //OsWDD (adress)
        public static int MultiplyTwo(int data)
        {
            return data * 2;
        }

        //delegate incapsulate adress
        public delegate int MathOperation(int data);

        //method that takes massive and delegate
        public static int[] DoSomeOperation(int[] data, MathOperation operation)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = operation(data[i]);
            }
            return data;
        }

        static void Main(string[] args)
        {

            int[] data = new int[] { 1, 2, 3, 4, 5 };

            //for example, lets imagine that val in entered from keyboard
            int val = 0;

            //set delegate link to method
            MathOperation operation;
            
            if (val > 0)
                operation = AddTwo;
            else
                operation = MultiplyTwo;

            //call method that takes massive and delegate that has link to method
            data = DoSomeOperation(data, operation);

            AddTwo(data[2]);


            //using Node for List (send any type)
            MyList<int> listInt = new MyList<int>();
            listInt.AddHead(1);
            listInt.AddHead(2);
            listInt.AddHead(3);

            int[] mas = new int[] {1, 2, 3, 4, 5 };

            //create employes massive with 3 employee objects
            Employee employee1 = new PMEmployee("firstName1", "lastName1", 1000, mas, "NoProject");
            PMEmployee employee2 = new PMEmployee("firstName2", "lastName2", 1000, mas, "Wex");
            DevEmployee employee3 = new DevEmployee("firstName3", "lastName3", 1000, mas, "Project");
            QAEmployee qaemployee = new QAEmployee("QaName", "QaSurname", 1500f, mas, "WEB");
            VacuumCleaner cleaner = new VacuumCleaner("Samsung");
            LeadQAEmployee leadqaemployee = new LeadQAEmployee("QaName", "QaSurname", 1500f, mas, "Lead");

            //Massive IWorkable type (interface)
            IWorkable[] employesMas = new IWorkable[] { employee1,
                                                        employee2,
                                                        employee3,
                                                        qaemployee,
                                                        cleaner,
                                                        leadqaemployee };

            //Use static method and counter for method calls
            DevEmployee.GetClassInfo();
            DevEmployee.GetClassInfo();
            DevEmployee.GetClassInfo();
            Console.WriteLine("Count of GetClassInfo method calls is {0} )", DevEmployee.NumberOfCalls);
            Console.WriteLine(" ");

            //Use static method without initialization class object
            int res = mas.Sum();
            Console.WriteLine("Sum of mas ellements is {0} ", res);
            Console.WriteLine(" ");

            string masRes = mas.MasToString();
            Console.WriteLine("Massive {0} ", masRes);
            Console.WriteLine(" ");

            //Simple list IWorkable type (interface)
            List<IWorkable> employesList = new List<IWorkable>();
            employesList.Add(employee1);
            employesList.Add(employee2);
            employesList.Add(employee3);
            employesList.Add(qaemployee);
            employesList.Add(cleaner);
            employesList.Add(leadqaemployee);

            Console.WriteLine("Massive of exact employee is ");
            Console.WriteLine(employee1.PrintMassive(mas));
            Console.WriteLine(" ");

            //initialize employees
            cleaner.Producer = "Xiaomi";

            //Work with massive element, using indexator
            Console.WriteLine("Exact element of exact employee {0}", employee1.Marks[4]);
            Console.WriteLine(" ");

            foreach (IWorkable employee in employesMas)
            {
            Console.WriteLine(employee.GetInfo());           
            }

            Console.WriteLine(" ");

            foreach (IWorkable worker in employesList)
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

        //Create task
        static void CreateTask(IJiraTaskCreatable creator, string info)
        {
            creator.CreateTask(info);
        }
    }
}
