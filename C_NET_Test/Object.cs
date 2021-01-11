using System;

namespace Objects
{
    class Objects
    {
            static void Main(string[] args)
        {
            //create employes massive with 3 employee objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee[] employes = new Employee[] { employee1, employee2, employee3 };

            //create departments massive with 3 department objects
            Department department1 = new Department();
            Department department2 = new Department();
            Department department3 = new Department();
            Department[] departments = new Department[] { department1, department2, department3 };

            //initialize employees
            Employee[] NewEmployes = SetEmployes(employes);
            //initialize departments
            Department[] NewDepartments = SetDepartments(departments);

            //sort and print Depatment and Employes massives
            Employee[] SortedEmployes = SortEmployeValues(NewEmployes);
            Department[] SortedDepartments = SortDepartmentValues(NewDepartments);

            SortedDepartments[0].departmentLocation = "new";
            SortedEmployes[0].lastName = "new";

            foreach (Employee xx in SortedEmployes)
            {
                Console.WriteLine("{0} {1}, salary {2}", xx.firstName, xx.lastName, xx.salary);
                Console.ReadKey();
            }
        }
        //method initializing Employees
        public static Employee[] SetEmployes (Employee[] SetMassive)
        {
            SetMassive[0] = new Employee() { firstName = "fn1", lastName = "ln1", salary = 1100f };
            SetMassive[1] = new Employee() { firstName = "fn2", lastName = "ln2", salary = 1200f };
            SetMassive[2] = new Employee() { firstName = "fn3", lastName = "ln3", salary = 1300f };
            return SetMassive;
        }
        //method initializing Departments
        public static Department[] SetDepartments(Department[] SetMassive)
        {
            SetMassive[0] = new Department() { departmentName = "QA", departmentLocation = "Chapaeva", departmentNumber = 1 };
            SetMassive[1] = new Department() { departmentName = "DEV", departmentLocation = "Chapaeva2", departmentNumber = 2 };
            SetMassive[2] = new Department() { departmentName = "BA", departmentLocation = "Gurskogo", departmentNumber = 3 };
            return SetMassive;
        }
        //method printing Departments
        public static void PrintMassiveDepartment(Department[] PrintMassive)
        {
            foreach (Department xx in PrintMassive)
            {
                Console.WriteLine("{0} {1}, departmentNumber {2}", xx.departmentName, xx.departmentLocation, xx.departmentNumber);
                Console.ReadKey();
            }
        }
        //method printing Employees
        public static void PrintMassiveEmployee(Employee[] PrintMassive)
        {
            foreach (Employee xx in PrintMassive)
            {
                Console.WriteLine("{0} {1}, salary {2}", xx.firstName, xx.lastName, xx.salary);
                Console.ReadKey();
            }
        }
        //method sorting and than printing Employees, using PrintMassiveEmployee method
        public static Employee[] SortEmployeValues(Employee[] SortMassive)
        {
            string temp = SortMassive[0].lastName;
            SortMassive[0].lastName = SortMassive[1].lastName;
            SortMassive[1].lastName = temp;
            PrintMassiveEmployee(SortMassive);
            return SortMassive;
        }
        //method sorting and than printing Departments, using PrintMassiveDepartment method
        public static Department[] SortDepartmentValues(Department[] SortMassive)
        {
            float temp = SortMassive[0].departmentNumber;
            SortMassive[0].departmentNumber = SortMassive[1].departmentNumber;
            SortMassive[1].departmentNumber = temp;
            PrintMassiveDepartment(SortMassive);
            return SortMassive;
        }
    }
}


