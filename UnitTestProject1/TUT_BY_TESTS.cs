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
        const string wordToFind = "virus";
        IWebDriver _driver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverDir);
        // private static readonly string _AfishaString = "//a[@title='Афиша']";
        //private static readonly string _searchString = "search_from_str";
        //private static readonly string _searchButtonString = "search";
        


        [TestMethod()]
        public void SearchTest()
        {
            MainPage mainPage = new MainPage(_driver);

            SearchResultsPage searchResultsPage = mainPage.SearchInfo("virus");

            Assert.IsTrue(searchResultsPage.Title.Contains("virus"));

        }

        public void CheckButtonTest()
        {
            MainPage mainPage = new MainPage(_driver);


        }

    }


}