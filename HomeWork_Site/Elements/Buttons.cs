using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_Site.Interfaces;


namespace HomeWork_Site
{
    class Buttons : WebElements, IClickable
    {
        public string Click { get; set; }

        public Buttons(string webElementName, Point webPoint, int webHight, int webWidth, string click) : base(webElementName, webPoint, webHight, webWidth)
        {
            Click = click;
        }

        public override string GetInfo()
        {
            return ElementName + ", " + WebPoint.GetInfo() + ", " + WebHight + ", " + WebWidth + ", " + Click;
        }

        string IClickable.Click()
        {
            return ElementName + " element is clicked";
        }
    }
}
