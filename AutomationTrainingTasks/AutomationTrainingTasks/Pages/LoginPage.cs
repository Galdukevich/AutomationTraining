using System.Threading;
using OpenQA.Selenium;

namespace Task20
{
    public class LoginPage
    {
        private const string URL = "https://tut.by/";
        private const string _loginPopUpButton = "enter";
        private const string _loginName = "login";
        private const string _passwordName = "password";
        private const string _loginButton = ".m-green";
        private IWebDriver _driver;       

        IWebElement _LoginPopUpButton;
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
            _LoginPopUpButton = _driver.FindElement(By.ClassName(_loginPopUpButton));
            _Login = _driver.FindElement(By.Name(_loginName));
            _Password = _driver.FindElement(By.Name(_passwordName));
            _Enter = _driver.FindElement(By.CssSelector(_loginButton));
        }

        public void LogIn(string login, string password)
        {
            _LoginPopUpButton.Click();
            Thread.Sleep(1000);
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
