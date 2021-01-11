using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork
{
    class RadioButton : WebElements, ISelectable
    {
        public string Select { get; set; }

        public RadioButton(string en, int lc, int hig, int wid, string select) : base(en, lc, hig, wid)
        {
            Select = select;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + LeftConor + ", " + Hight + ", " + Width + ", " + Select;
        }

        string ISelectable.Select()
        {
            return ElementName + " is selected";
        }
    }
}
