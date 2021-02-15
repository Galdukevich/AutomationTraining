using OpenQA.Selenium;
using TUT_BY_POST_TEST.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace TUT_BY_POST_TESTS.Pages
{
    public class MainPage
    {
        private const string _letterClassName = "mail-MessageSnippet-FromText";
        private const string _letterList_XPath = "/html/body/div[2]/div[6]/div/div[3]/div[3]/div[2]/div[5]/div[1]/div/div/div[2]";
        private const string _newLetterButton_XPath = "/html/body/div[2]/div[6]/div/div[3]/div[2]/div[2]/div/div/a";
        private const string _newLetterAdress_InputField_ClassName = "composeYabbles";
        private const string _newLetterTheme_InputField_XPath = "/html/body/div[2]/div[9]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/div[1]/div/div[1]/div[1]/div[3]/div/div/input";
        private const string _newLetterContent_InputField_XPath = "/html/body/div[2]/div[9]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div/div/div[1]/div/div/div";
        private const string _newLetterSendButton_XPath = "/html/body/div[2]/div[9]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/div[2]/div/div[1]/div[1]/button";

        private IWebDriver _driver;
        IWebElement _NewLetterButton;
        IWebElement _NewLetterAdress;
        IWebElement _NewLetterTheme;
        IWebElement _NewLetterContent;
        IWebElement _NewLetterSendButton;
        IWebElement _Letter;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CreateNewLetter(string adresse, string letterTheme, string letterContent)
        {
            Thread.Sleep(1000);
            _NewLetterButton = _driver.FindElement(By.XPath(_newLetterButton_XPath));
            Thread.Sleep(1000);
            _NewLetterButton.Click();
            Thread.Sleep(1000);
            _NewLetterAdress = _driver.FindElement(By.ClassName(_newLetterAdress_InputField_ClassName));
            _NewLetterAdress.SendKeys(adresse);
            Thread.Sleep(1000);
            _NewLetterTheme = _driver.FindElement(By.XPath(_newLetterTheme_InputField_XPath));
            _NewLetterTheme.SendKeys(letterTheme);
            Thread.Sleep(1000);
            _NewLetterContent = _driver.FindElement(By.XPath(_newLetterContent_InputField_XPath));
            _NewLetterContent.SendKeys(letterContent);
            Thread.Sleep(1000);
            _NewLetterSendButton = _driver.FindElement(By.XPath(_newLetterSendButton_XPath));
            _NewLetterSendButton.Click();
            Thread.Sleep(1000);
        }

        public void Find_and_Open_LastLetter()
        {
            var _Letter = _driver.FindElements(By.TagName("TEST")).ToList();

            //_Letter.Click();
        }

        public ReLoginPage OpenReLoginPage()
        {
            return new ReLoginPage(_driver);
        }

        public LetterPage OpenLetterPage()
        {
            return new LetterPage(_driver);
        }
    }
}

