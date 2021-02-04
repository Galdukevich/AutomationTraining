using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_Site.Interfaces;

namespace HomeWork_Site
{
    class RadioButton : WebElements, ISelectable
    {
        public string Select { get; set; }

        public RadioButton(string webElementName, Point webPoint, int webHight, int webWidth, string select) : base(webElementName, webPoint, webHight, webWidth)
        {
            Select = select;
        }
        public override string GetInfo()
        {
            return ElementName + ", " + WebPoint.GetInfo() + ", " + WebHight + ", " + WebWidth + ", " + Select;
        }

        string ISelectable.Select()
        {
            return ElementName + " is selected";
        }
    }
}
