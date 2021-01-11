using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork
{
    abstract class WebElements
    {
        public string ElementName { get; set; }

        public int LeftConor { get; set; }

        public int Hight { get; set; }

        public int Width { get; set; }

        public WebElements(string en, int lc, int hig, int wid)
        {
            ElementName = en;
            LeftConor = lc;
            Hight = hig;
            Width = wid;
        }
        public abstract string GetInfo();
    }
}
