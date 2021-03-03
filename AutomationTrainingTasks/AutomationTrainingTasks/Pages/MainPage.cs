using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task20
{
    public class MainPage
    {
        private const string _userNamePanelByClass = "uname";

        private IWebDriver _driver;
        IWebElement _UserNamePanel;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetUserName(ref string username)
        {
            _UserNamePanel = _driver.FindElement(By.ClassName(_userNamePanelByClass));
            username = _UserNamePanel.Text;
            return username;
        }
    }
}
