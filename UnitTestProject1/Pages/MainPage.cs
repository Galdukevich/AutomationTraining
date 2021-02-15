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
        private static readonly string _searchString = "search_from_str";
        private static readonly string _searchButtonString = "search";

        IWebElement _searchButton;
        IWebElement _searchField;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl("http:\\tut.by");
            Initialize();
        }

        public void Initialize()
        {
            _searchButton = _driver.FindElement(By.Name(_searchButtonString));
            _searchField = _driver.FindElement(By.Id(_searchString));
        }

        public void OpenSearchPage(string wordToFind)
        {
            _searchField.SendKeys(wordToFind);
            //Thread.Sleep(1000);
            _searchButton.Click();
        }


        public SearchResultsPage SearchInfo(string wordToFind)
        {
            _searchField.SendKeys(wordToFind);
            //Thread.Sleep(1000);
            _searchButton.Click();
            return new SearchResultsPage(_driver, wordToFind);
        }
    }
}
