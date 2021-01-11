using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Buttons button1 = new Buttons("button1", 10, 20, 30, "clickable");
            EditBoxes editBox1 = new EditBoxes("editBox1", 15, 25, 35, "clickable");
            Links link1 = new Links("link1", 30, 50, 5, "clickable");
            Menus menu1 = new Menus("menu1", 0, 5, 5, "clickable");
            Pics pic1 = new Pics("pic1", 50, 70, 30, "ColorChangeable");
            Selectors selector1 = new Selectors("selector1", 55, 20, 15, "selectable");
            Text text1 = new Text("text1", 20, 15, 45, "SomeOption");            
            Selectors selector2 = new Selectors("selector2", 05, 25, 30, "selectable");
            Selectors selector3 = new Selectors("selector3", 50, 10, 10, "selectable");
            Menus menu2 = new Menus("menu2", 90, 55, 5, "clickable");
            Text text2 = new Text("text2", 20, 15, 45, "SomeOption");
            Pics pic2 = new Pics("pic2", 50, 70, 30, "ColorChangeable");
            Links link2 = new Links("link2", 30, 50, 5, "clickable");
            RadioButton radioButton = new RadioButton("radioButton", 35, 40, 80, "selectable");

            WebElements[] webElements = { button1,
                                          editBox1,
                                          link1,
                                          menu1,
                                          pic1,
                                          selector1,                                          
                                          text1,
                                          selector2,                                          
                                          selector3,
                                          menu2,
                                          text2,
                                          pic2,
                                          link2,
                                          radioButton
                                                      };

            foreach (WebElements element in webElements)
            {
                Console.WriteLine(element.GetInfo());
            }

            Console.WriteLine(" ");

            foreach (WebElements element in webElements)
            {
                if (element is IClickable)
                {
                    IClickable elementClickable = (IClickable)element;
                    elementClickable.Click();
                    Console.WriteLine(elementClickable.Click());                    
                }
            }
            foreach (WebElements element in webElements)
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
