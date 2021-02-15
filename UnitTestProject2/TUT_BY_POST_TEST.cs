using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using WebDriverIntroTests1.Pages;

namespace WebDriverIntro.Tests
{

    [TestClass()]
    public class WebDriverTests
    {
        const string chromeDriverDir = @"C:\Users\alexandergaldukevich\source\repos\UnitTestProject1\UnitTestProject1\";
        const string login = "segbesrgesrgre@tut.by";
        const string password = "1qaz!QAZ";
        IWebDriver _driver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverDir);
        public string text;

        [TestMethod()]
        public void SearchTest()
        {
            MainPage mainPage = new MainPage(_driver);
            mainPage.Initialize();
            mainPage.OpenSearchPage(login, password);
            mainPage.Initialize2();
            ResultsPage resultsPage = mainPage.SearchInfo();

            resultsPage.Initialize3(ref text);
            Assert.IsTrue(text.Contains("TEST"));
        }
    }
}