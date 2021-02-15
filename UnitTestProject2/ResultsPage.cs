using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverIntroTests1.Pages
{
    public class ResultsPage
    {
        private IWebDriver _driver;
        IWebElement _Content;
        public ResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string Initialize3(ref string text)
        {
            _Content = _driver.FindElement(By.ClassName("mail-Message-Content"));
            text = _Content.Text;
            return text;
        }
    }
}
