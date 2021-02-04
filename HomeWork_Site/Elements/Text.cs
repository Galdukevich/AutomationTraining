using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_Site.Interfaces;

namespace HomeWork_Site
{
    class Text : WebElements
    {
        public string Option { get; set; }

        public Text(string webElementName, Point webPoint, int webHight, int webWidth, string language) : base(webElementName, webPoint, webHight, webWidth)
        {
            Option = language;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + WebPoint.GetInfo() + ", " + WebHight + ", " + WebWidth + ", " + Option;
        }
    }
}
