using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_Site.Interfaces;

namespace HomeWork_Site
{
    class Pics : WebElements, IChangable
    {
        public string ChangeColor { get; set; }

        public Pics(string webElementName, Point webPoint, int webHight, int webWidth, string changeColor) : base(webElementName, webPoint, webHight, webWidth)
        {
            ChangeColor = changeColor;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + WebPoint.GetInfo() + ", " + WebHight + ", " + WebWidth + ", " + ChangeColor;
        }
        string IChangable.Change()
        {
            return ElementName + " element is changed";
        }
    }
}
