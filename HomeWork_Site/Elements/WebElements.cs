using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_Site.Interfaces;

namespace HomeWork_Site
{
        public abstract class WebElements
    {
        public string ElementName { get; set; }
        public Point WebPoint { get; set; }
        public int WebHight { get; set; }
        public int WebWidth { get; set; }

        public WebElements(string webElementName, Point webPoint, int webHight, int webWidth)
        {
            ElementName = webElementName;
            WebPoint = webPoint;
            WebHight = webHight;
            WebWidth = webWidth;
        }
        public abstract string GetInfo();
    }
}
