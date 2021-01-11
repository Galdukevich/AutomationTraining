using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork
{
    class Pics : WebElements, IChangable
    {
        public string ChangeColor { get; set; }

        public Pics(string en, int lc, int hig, int wid, string changeColor) : base(en, lc, hig, wid)
        {
            ChangeColor = changeColor;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + LeftConor + ", " + Hight + ", " + Width + ", " + ChangeColor;
        }
        string IChangable.Change()
        {
            return ElementName + " element is changed";
        }
    }
}
