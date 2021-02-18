using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TUT_BY_POST_TESTS.Pages;

namespace TUT_BY_POST_TEST.Pages
{
    public class LoginPage
    {
        private const string URL = "https://mail.tut.by/";       
        private const string _login_ID_InputField = "Username";
        private const string _password_ID_InputField = "Password";
        private const string _loginButtonXPath = "/ html / body / div / div[1] / div[2] / div[1] / div[2] / div / form / fieldset / div[3] / input";
        private IWebDriver _driver;

        IWebElement _Login;
        IWebElement _Password;
        IWebElement _Enter;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(URL);
            Initialize();
        }

        public void Initialize()
        {
            _Login = _driver.FindElement(By.Id(_login_ID_InputField));
            Thread.Sleep(1000);
            _Password = _driver.FindElement(By.Id(_password_ID_InputField));
            Thread.Sleep(1000);
            _Enter = _driver.FindElement(By.XPath(_loginButtonXPath));
        }

        public void LogIn (string login, string password)
        {
            _Login.SendKeys(login);
            Thread.Sleep(1000);
            _Password.SendKeys(password);
            Thread.Sleep(1000);
            _Enter.Click();
        }

        public MainPage OpenMainPage()
        {
            return new MainPage(_driver);
        }
    }
}
