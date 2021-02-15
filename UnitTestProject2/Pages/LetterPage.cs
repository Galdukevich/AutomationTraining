using OpenQA.Selenium;
using TUT_BY_POST_TEST.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TUT_BY_POST_TESTS.Pages;

namespace TUT_BY_POST_TEST.Pages
{
    public class LetterPage
    {
        private const string _letterContentClassName = "mail-Message-Content";
        private const string _quickReplyInputField_XPath = "/html/body/div[2]/div[6]/div/div[3]/div[3]/div[2]/div[5]/div[1]/div/div[4]/div/div/div/div[2]/div/label[2]/div[2]/div/div/div/div/div";
        private const string _quickReplySendButton_ClassName = "_nb-button-content";
        private IWebDriver _driver;

        IWebElement _Content;
        IWebElement _QuickReply;
        IWebElement _QuickReplySendButton;

        public LetterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string FindLetterText(ref string text)
        {
            _Content = _driver.FindElement(By.ClassName(_letterContentClassName));
            text = _Content.Text;
            return text;
        }

        public void AnswerMessage(string answer)
        {
            _QuickReply = _driver.FindElement(By.XPath(_quickReplyInputField_XPath));
            Thread.Sleep(1000);
            _QuickReply.SendKeys(answer);
            Thread.Sleep(1000);
            _QuickReplySendButton = _driver.FindElement(By.ClassName(_quickReplySendButton_ClassName));
            _QuickReplySendButton.Click();
        }

        public ReLoginPage OpenReLoginPage()
        {
            return new ReLoginPage(_driver);
        }
    }
}
