using HomeWork_Site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Site
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize Point
            Point point = new Point(1, 2);
            //create empty window
            Window window = new Window (new Point(1, 2), 20, 30);

            //initialize web elements
            Buttons button = new Buttons("Button1", new Point(1, 1), 10, 10, "clickable");
            EditBoxes editBoxes = new EditBoxes("EditBox1", new Point(1, 1), 10, 10, "clickable");
            Links links = new Links("Link1", new Point(1, 1), 10, 10, "clickable");
            Menus menus = new Menus("Menu1", new Point(1, 1), 10, 10, "clickable");
            Pics pics = new Pics("Pic1", new Point(1, 1), 10, 10, "ColorChangable");
            RadioButton radiobutton = new RadioButton("RadioButton1", new Point(1, 1), 10, 10, "Selectable");
            Selectors selector = new Selectors("Selector1", new Point(1, 1), 10, 10, "clickable");
            Text text = new Text("Text1", new Point(1, 1), 10, 10, "English");

            //initialize web elements
            Buttons button2 = new Buttons("Button2", new Point(2, 2), 20, 20, "clickable");
            EditBoxes editBoxes2 = new EditBoxes("EditBox2", new Point(2, 2), 20, 20, "clickable");
            Links links2 = new Links("Link2", new Point(2, 2), 20, 20, "clickable");
            Menus menus2 = new Menus("Menu2", new Point(2, 2), 20, 20, "clickable");
            Pics pics2 = new Pics("Pic2", new Point(2, 2), 20, 20, "ColorChangable");
            RadioButton radiobutton2 = new RadioButton("RadioButton2", new Point(2, 2), 20, 20, "Selectable");
            Selectors selector2 = new Selectors("Selector2", new Point(2, 2), 20, 20, "clickable");
            Text text2 = new Text("Text2", new Point(2, 2), 20, 20, "English");

            //initialize web elements
            Buttons button3 = new Buttons("Button3", new Point(3, 3), 30, 30, "clickable");
            EditBoxes editBoxes3 = new EditBoxes("EditBox3", new Point(3, 3), 30, 30, "clickable");
            Links links3 = new Links("Link3", new Point(3, 3), 30, 30, "clickable");
            Menus menus3 = new Menus("Menu3", new Point(3, 3), 30, 30, "clickable");
            Pics pics3 = new Pics("Pic3", new Point(3, 3), 30, 30, "ColorChangable");
            RadioButton radiobutton3 = new RadioButton("RadioButton3", new Point(3, 3), 30, 30, "Selectable");
            Selectors selector3 = new Selectors("Selector3", new Point(3, 3), 30, 30, "clickable");
            Text text3 = new Text("Text3", new Point(3, 3), 30, 30, "English");

            //create list1 of web elements
            List<WebElements> webElements1 = new List<WebElements>();
            webElements1.Add(button2);
            webElements1.Add(editBoxes);
            webElements1.Add(links);
            webElements1.Add(menus3);
            webElements1.Add(pics);
            webElements1.Add(radiobutton);
            webElements1.Add(selector3);
            webElements1.Add(text2);

            //create list2 of web elements
            List<WebElements> webElements2 = new List<WebElements>();
            webElements2.Add(button);
            webElements2.Add(editBoxes3);
            webElements2.Add(links);
            webElements2.Add(menus2);
            webElements2.Add(pics);
            webElements2.Add(radiobutton);
            webElements2.Add(selector3);
            webElements2.Add(text);

            //create list3 of web elements
            List<WebElements> webElements3 = new List<WebElements>();
            webElements3.Add(button3);
            webElements3.Add(editBoxes);
            webElements3.Add(links);
            webElements3.Add(menus2);
            webElements3.Add(pics);
            webElements3.Add(radiobutton);
            webElements3.Add(selector);
            webElements3.Add(text2);

            //create windows with list of web elements
            Window window1 = new Window("Window1", new Point(1, 1), 10, 10, webElements1);
            Window window2 = new Window("Window2", new Point(2, 2), 20, 20, webElements2);
            Window window3 = new Window("Window3", new Point(3, 3), 30, 30, webElements3);

            //create list of windows with web elements
            List<Window> windowList = new List<Window>();
            windowList.Add(window1);
            windowList.Add(window2);
            windowList.Add(window3);

            //select Points for all windows and order them by descending
            var fixedsizeWindows1 = windowList.Select(x => (x.Point))
                                              .OrderByDescending(x => (x.X, x.Y))
                                              .ToList();

            //select Point for all windows that are > 1
            var fixedsizeWindows2 = windowList.Select(x => (x.Point, x.WindowName))
                                              .Where(x => (x.Point.X > 1 && x.Point.Y > 1))
                                              .Select(x => x.WindowName)
                                              .ToList();

            //select all unique web elements from all windows
            var fixedsizeWindows3 = windowList.SelectMany(x => x.WebElements)
                                              .Distinct()
                                              .OrderBy(x => x.ElementName)
                                              .ToList();

            // select all web elements from all windows
            var fixedsizeWindows4 = windowList.SelectMany(x => x.WebElements)                
                                              .ToList();

            //write all windows info
            foreach (Window element in windowList)
            {
                Console.WriteLine(element.GetInfo());
            }

            Console.WriteLine(" ");

            //write all web elements info from all windows
            foreach (WebElements element in fixedsizeWindows4)
            {
                Console.WriteLine(element.GetInfo());
            }
           
            Console.WriteLine(" ");

            //write all unique web elements from all windows
            foreach (WebElements element in fixedsizeWindows3)
            {
                Console.WriteLine(element.ElementName);
            }

            Console.WriteLine(" ");

            //select and print all clickable web elements from all pages
            foreach (WebElements element in fixedsizeWindows4)
            {
                if (element is IClickable)
                {
                    IClickable elementClickable = (IClickable)element;
                    elementClickable.Click();
                    Console.WriteLine(elementClickable.Click());
                }
            }

            Console.WriteLine(" ");

            //select and print all selectable web elements from all pages
            foreach (WebElements element in fixedsizeWindows4)
            {
                if (element is ISelectable)
                {
                    ISelectable elementSelectable = (ISelectable)element;
                    elementSelectable.Select();
                    Console.WriteLine(elementSelectable.Select());
                }
            }
            Console.ReadKey();
        }
    }
}
