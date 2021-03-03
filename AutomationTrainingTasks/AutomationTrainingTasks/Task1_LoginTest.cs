using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Task20
{
    [TestFixture]
    public class WebDriverTests
    {       
        const string login = "segbesrgesrgre@tut.by";
        const string password = "1qaz!QAZ";
        const string username = "цукыпацуп цупауцп";
        string loggedUser;

        [Test]
        public void LoginTestFirefox()
        {
            IWebDriver _driver = new FirefoxDriver();

            //create new login page
            LoginPage loginPage = new LoginPage(_driver);
            //enter login and password
            loginPage.LogIn(login, password);

            //go to MainPage
            MainPage mainPage = loginPage.OpenMainPage();
            //get username
            mainPage.GetUserName(ref loggedUser);

            Assert.AreEqual(username, loggedUser);

            _driver.Close();
        }

        [Test]
        public void Task2_FindLocatorsChrome()
        {
            IWebDriver _driver = new ChromeDriver();

            //create new page
            Task2_FindLocators page = new Task2_FindLocators(_driver);
            //initialize elments by different locators
            page.Initialize();

            _driver.Close();
        }
    }
}