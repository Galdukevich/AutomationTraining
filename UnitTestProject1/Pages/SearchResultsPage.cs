using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT_BY_POST_TEST.Pages
{
    public class SearchResultsPage
    {
        private IWebDriver _driver;
        private string _searchWord;
        public SearchResultsPage(IWebDriver driver, string searchWord)
        {
            _driver = driver;
            _searchWord = searchWord;
        }

        public string Title { get => _driver.Title; }

        public bool IsFound()
        {
            return Title.Contains(_searchWord);
        }

        public void ReturnToMainPage()
        {
            _driver.Navigate().GoToUrl("http:\\tut.by");
        }


    }
}
