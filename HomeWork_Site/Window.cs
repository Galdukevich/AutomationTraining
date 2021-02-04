using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Site
{
   public class Window
    {
        public string WindowName { get; set; }
        public int Lenght { get; set; }
        public int Width { get; set; }
        public Point Point { get; set; }
        public List <WebElements> WebElements { get; set; }

        //constractor for window with web elements
        public Window(string windowName, Point windowPoint, int windowLenght, int windowWidth, List <WebElements> webElement)
        {
            WindowName = windowName;
            WebElements = webElement;
            Point = windowPoint;
            Lenght = windowLenght;
            Width = windowWidth;
        }

        //constructor for empty window
        public Window(Point windowPoint, int windowLenght, int windowWidth)
        {
            Point = windowPoint;
            Lenght = windowLenght;
            Width = windowWidth;
        }



        public string GetInfo()
        {
            return WindowName + ", " + Point.GetInfo() + ", " + Lenght + ", " + Width;
        }
    }
}
