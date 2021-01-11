using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Text : WebElements
    {
        public string Option { get; set; }

        public Text(string en, int lc, int hig, int wid, string language) : base(en, lc, hig, wid)
        {
            Option = language;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + LeftConor + ", " + Hight + ", " + Width + ", " + Option;
        }
    }
}
