using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Delegate
{
    class Program
    {
            static void Main(string[] args)
        {
            //creating 10 new windows
            Window window1 = new Window(5, 5, 5, 5);
            Window window2 = new Window(10, 10, 10, 10);
            Window window3 = new Window(15, 15, 15, 15);
            Window window4 = new Window(20, 20, 20, 20);
            Window window5 = new Window(30, 30, 30, 30);
            Window window6 = new Window(40, 40, 40, 40);
            Window window7 = new Window(50, 50, 50, 50);
            Window window8 = new Window(60, 60, 60, 60);
            Window window9 = new Window(70, 70, 70, 70);
            Window window10 = new Window(80, 80, 80, 80);

            //Window window11 = new Window(new Point(1, 2), 5 5);

            //creating MyList using generic
            List<Window> windowList = new List<Window>();           
            windowList.Add(window1);
            windowList.Add(window2);
            windowList.Add(window3);
            windowList.Add(window4);
            windowList.Add(window5);
            windowList.Add(window6);
            windowList.Add(window7);
            windowList.Add(window8);
            windowList.Add(window9);
            windowList.Add(window10);

            var points = windowList.Select(x => (x.Width, x.Lenght)).Where(x => x.Width == 5).Select(x => (x, 0)).ToList();



            //select 2 variables from windowList and input them in new list
            var fixedsizeWindows2 = windowList.Select(x => (x.Width, x.Lenght))
                                              .Where(x => x.Width == 5);
                                              //.OrderBy...
                                              //.ToList();
            //using new list with 2 variables, output there values on console
            foreach (var item in fixedsizeWindows2)
            {
                Console.WriteLine("{0}, {1}", item.Width, item.Lenght);
            }

            //select all windows with Width = 5, and input into FixedSizeWindows list
            var fixedsizeWindows = new List<Window>();
            foreach(var window in windowList)
            {
                if (window.Width == 5)
                {
                    fixedsizeWindows.Add(window);
                }
            }

            //the same operation using Linq (select all windows with Width = 5, and input into FixedSizeWindows list)
            var linqExpression = windowList.Where(x => x.Width == 5);
            fixedsizeWindows = linqExpression.ToList();

            //the same operation more shoter
            fixedsizeWindows = windowList.Where(x => x.Width == 5).ToList();

            

            //entering command from keyboard
            string command = Console.ReadLine();

            //creating delegate variable to record link to neccessary method
            Window.WindowAction<Window> operation;

            if (command == "MoveLeft")               
            {
                //Set delegate variable method MoveLeft
                operation = Window.MoveLeft;
                //call method that takes massive and delegate that has link to neccessary method
                Window.DoSomeOperation(windowList, operation);
            }
            if (command == "MoveRight")
            {
                operation = Window.MoveRight;
                Window.DoSomeOperation(windowList, operation);
            }
            if (command == "MoveUp")
            {
                operation = Window.MoveUp;
                Window.DoSomeOperation(windowList, operation);
            }
            if (command == "MoveDown")
            {
                operation = Window.MoveDown;
                Window.DoSomeOperation(windowList, operation);
            }
            if (command == "Resize")
            {
                operation = Window.Resize;
                Window.DoSomeOperation(windowList, operation);
            }


            Window.WindowAction<int> operationInt;
            int[] massive = { 1, 2, 3 };
            //operationInt = Window.DoSomething;
            //Window.PrintMassive(massive, operationInt);

            //anoniumois method with short delegate
            Func<Window, Window> del1 = delegate (Window data)
            {
                data.X += 1;
                return data;
            };          

            //anoniumois method with more shorter delegate
            //Func<int, int> del = data => { data.X += 1; return data; };
            //Window.PrintMassive(windowList, del);
        }
    }
}
