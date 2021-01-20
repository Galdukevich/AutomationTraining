using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Delegate
{
    class Window
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Lenght { get; set; }
        public int Width { get; set; }

        public Window (int x, int y, int le, int wi)
        {
            X = x;
            Y = y;
            Lenght = le;
            Width = wi;           
        }

        //MoveLeft method, moves window left for 2 points       
        public static Window MoveLeft(Window data)
        {
            data.X = data.X - 2;
            return data;
        }
        //MoveRight method, moves window right for 2 points  
        public static Window MoveRight(Window data)
        {
            data.X = data.X + 2;
            return data;
        }
        //MoveUp method, moves window up for 2 points
        public static Window MoveUp(Window data)
        {
            data.Y = data.Y - 2;
            return data;
        }
        //MoveDown method, moves window down for 2 points
        public static Window MoveDown(Window data)
        {
            data.Y = data.Y + 2;
            return data;
        }
        //Resize method, add 2 points for windows lenght and 2 points for windows width
        public static Window Resize(Window data)
        {
            data.Lenght = data.Lenght + 2;
            data.Width = data.Width + 2;
            return data;
        }

        //delegate incapsulate adress
        public delegate Window WindowAction(Window window);

        //method that takes List and delegate variable
        public static List<Window> DoSomeOperation(List<Window> window, WindowAction operation)
        {
            for (int i = 0; i < window.Count; i++)
            {
                window[i] = operation(window[i]);
            }
            return window;
        }
    }
}
