using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork
{
    class Menus : WebElements, IClickable
    {
        public string Click { get; set; }

        public Menus(string en, int lc, int hig, int wid, string click) : base(en, lc, hig, wid)
        {
            Click = click;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + LeftConor + ", " + Hight + ", " + Width + ", " + Click;
        }
        string IClickable.Click()
        {
            return ElementName + " element is clicked";
        }
    }
}
