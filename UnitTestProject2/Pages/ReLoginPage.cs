using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TUT_BY_POST_TEST.Pages;

namespace TUT_BY_POST_TESTS.Pages
{
    public class ReLoginPage
    {
        private const string _reloginURL = "https://passport.yandex.ru/passport?mode=embeddedauth&action=change_default&uid=1130000050332485&yu=2939169151613417521&retpath=https%3A%2F%2Fmail.yandex.ru";
        private const string _addAcountButton_ClassName = "AddAccountButton";
        private const string _yandexLoginInputField_ClassName = "Textinput-Control";
        private const string _loginButton_XPath = "/html/body/div/div/div[2]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/form/div[3]/button";
        private const string _yandexPasswordInputField_ClassName = "Textinput-Control";
        private const string _loginButtonSubmit_XPath = "/html/body/div/div/div[2]/div[2]/div/div/div[2]/div[3]/div/div/div/form/div[3]/button";
        private IWebDriver _driver;

        IWebElement _AddAcountButton;
        IWebElement _YandexLogin;
        IWebElement _LoginButton;
        IWebElement _YandexPassword;
        IWebElement _LoginButtonSubmit;

        public ReLoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Re_Log_in(string login, string password)
        {
            _driver.Navigate().GoToUrl(_reloginURL);
            Thread.Sleep(1000);
            _AddAcountButton = _driver.FindElement(By.ClassName(_addAcountButton_ClassName));
            _AddAcountButton.Click();
            Thread.Sleep(1000);
            _YandexLogin = _driver.FindElement(By.ClassName(_yandexLoginInputField_ClassName));
            _YandexLogin.SendKeys(login);
            Thread.Sleep(1000);
            _LoginButton = _driver.FindElement(By.XPath(_loginButton_XPath));
            _LoginButton.Click();
            Thread.Sleep(1000);
            _YandexPassword = _driver.FindElement(By.ClassName(_yandexPasswordInputField_ClassName));
            _YandexPassword.SendKeys(password);
            Thread.Sleep(1000);
            _LoginButtonSubmit = _driver.FindElement(By.XPath(_loginButtonSubmit_XPath));
            _LoginButtonSubmit.Click();
            Thread.Sleep(1000);
        }

        public MainPage OpenMainPage()
        {
            return new MainPage(_driver);
        }
    }
}
