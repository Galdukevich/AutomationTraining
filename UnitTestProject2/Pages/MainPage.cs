using OpenQA.Selenium;
using TUT_BY_POST_TEST.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace TUT_BY_POST_TESTS.Pages
{
    public class MainPage
    {                                                
        private const string _letterList_XPath = ".//html/body/div[2]/div[7]/div/div[3]/div[3]/div[2]/div[5]/div[1]/div/div/div[2]/div//*";
        private const string _newLetterButton_XPath = "/html/body/div[2]/div[7]/div/div[3]/div[2]/div[2]/div/div/a";
        private const string _newLetterAdress_InputField_ClassName = "composeYabbles";                                                                     
        private const string _newLetterTheme_InputField_XPath = "/html/body/div[2]/div[10]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/div[1]/div/div[1]/div[1]/div[3]/div/div/input";
        private const string _newLetterContent_InputField_XPath = "/html/body/div[2]/div[10]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div/div/div[1]/div/div/div";
        private const string _newLetterSendButton_XPath = "/html/body/div[2]/div[10]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/div[2]/div/div[1]/div[1]/button";
        private const string _notReaded_XPath = "/html/body/div[2]/div[7]/div/div[3]/div[2]/div[3]/div/div[2]/div[1]/div[2]/span/a/span/span/span";

        private IWebDriver _driver;
        IWebElement _NewLetterButton;
        IWebElement _NewLetterAdress;
        IWebElement _NewLetterTheme;
        IWebElement _NewLetterContent;
        IWebElement _NewLetterSendButton;
        IWebElement _NotReaded;

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

        public void FindAndOpenLastLetter()
        {
            //find list of all letters
            List<IWebElement> _Letter = _driver.FindElements(By.XPath(_letterList_XPath))
                                               .ToList();
            Thread.Sleep(1000);

            //this XPath find letters, that contain class state_ToRead, title "Mark as read", and find all next elements on this level (need to click)
            var _NewLetterList = _Letter.SelectMany(x => x.FindElements(By.XPath(".//span[contains(@class, 'state_toRead')]/../following-sibling::span")))
                                        .ToList();
            Thread.Sleep(1000);

            //we find all unread letters and opening first
            _NewLetterList[0].Click();
        }

        public void FindAndOpenLetterAnswer()
        {
            Thread.Sleep(1000);
            //we find all unread letters
            var _NotReaded = _driver.FindElement(By.XPath(_notReaded_XPath));
            _NotReaded.Click();
            Thread.Sleep(1000);

            //find list of all letters
            List<IWebElement> _Letter = _driver.FindElements(By.XPath(_letterList_XPath))
                                               .ToList();
            Thread.Sleep(1000);

            //this XPath find letters, that contain class state_ToRead, title "Mark as read", and find all next elements on this level (need to click)
            var _NewLetterList = _Letter.SelectMany(x => x.FindElements(By.XPath(".//span[contains(@class, 'state_toRead')]/../following-sibling::span")))
                                        .ToList();
            Thread.Sleep(1000);

            //we find all unread letters and opening first
            _NewLetterList[0].Click();

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

