using OpenQA.Selenium;

namespace Task20
{
    class Task2_FindLocators
    {
        private const string URL = "https://tut.by/";
        private const string _elementClassName = "inform-text";
        private const string _elementCssSelector = ".m-green";
        private const string _elementID = "pageLogo";
        private const string _elementLinkText = "Twitter";
        private const string _elementName = "search";
        private const string _elementPartialLinkText = "Teleg";
        private const string _elementTagName = "li";
        private const string _elementXPath = ".//a[contains(@class, 'enter')]";
        private IWebDriver _driver;

        IWebElement _ElementClassName;
        IWebElement _ElementCssSelector;
        IWebElement _ElementID;
        IWebElement _ElementLinkText;
        IWebElement _ElementName;
        IWebElement _ElementPartialLinkText;
        IWebElement _ElementTagName;
        IWebElement _ElementXPath;

        public Task2_FindLocators(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(URL);
        }

        public void Initialize()
        {
            _ElementClassName = _driver.FindElement(By.ClassName(_elementClassName));

            _ElementCssSelector = _driver.FindElement(By.CssSelector(_elementCssSelector));

            _ElementID = _driver.FindElement(By.Id(_elementID));

            _ElementLinkText = _driver.FindElement(By.LinkText(_elementLinkText));

            _ElementName = _driver.FindElement(By.Name(_elementName));

            _ElementPartialLinkText = _driver.FindElement(By.PartialLinkText(_elementPartialLinkText));

            _ElementTagName = _driver.FindElement(By.TagName(_elementTagName));

            _ElementXPath = _driver.FindElement(By.XPath(_elementXPath));
        }      
    }    
}
