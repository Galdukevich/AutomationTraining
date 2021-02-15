using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverIntroTests1.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;
        private static readonly string _login = "Username";
        private static readonly string _password = "Password";
        private static readonly string _enter = "login_action";

        IWebElement _Login;
        IWebElement _Password;
        IWebElement _Enter;
        IWebElement _Letter;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl("https://mail.tut.by/");
            Initialize();
        }

        public void Initialize()
        {
            _Login = _driver.FindElement(By.Id(_login));
            Thread.Sleep(1000);
            _Password = _driver.FindElement(By.Id(_password));
            Thread.Sleep(1000);
            _Enter = _driver.FindElement(By.XPath("/ html / body / div / div[1] / div[2] / div[1] / div[2] / div / form / fieldset / div[3] / input"));
        }

        public void OpenSearchPage(string login, string password)
        {
            _Login.SendKeys(login);
            Thread.Sleep(1000);
            _Password.SendKeys(password);
            Thread.Sleep(1000);
            _Enter.Click();
        }

        public void Initialize2()
        {
            _Letter = _driver.FindElement(By.ClassName("mail-MessageSnippet-FromText"));
            _Letter.Click();      
        }

        public ResultsPage SearchInfo()
        {
            return new ResultsPage(_driver);
        }
    }
}
