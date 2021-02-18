using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TUT_BY_POST_TEST.Pages;
using TUT_BY_POST_TESTS.Pages;

namespace TUT_BY_POST_TEST.Tests
{

    [TestClass()]
    public class WebDriverTests
    {
        IWebDriver _driver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverDir);

        const string chromeDriverDir = @"C:\Users\alexandergaldukevich\source\repos\UnitTestProject1\UnitTestProject1\";
        const string login = "segbesrgesrgre@tut.by";
        const string password = "1qaz!QAZ";
        const string login2 = "shrtehrsthrsth@tut.by";
        const string adresse = "ergf rtg";
        const string letterTheme = "LastTEST";
        const string letterContent = "LastTEST";
        string text;
        const string answerMail = "LastTestAnswer";

        [TestMethod()]
        public void SearchTest()
        {
            //create new login page
            LoginPage loginPage = new LoginPage(_driver);
            //enter login and password for acc1
            loginPage.LogIn(login, password);


            //go to MainPage
            MainPage mainPageAcc1 = loginPage.OpenMainPage();
            //create new letter and send to acc2
            mainPageAcc1.CreateNewLetter(login2, letterTheme, letterContent);


            //go to ReLoginPage and login with acc2
            ReLoginPage reloginPage = mainPageAcc1.OpenReLoginPage();
            reloginPage.Re_Log_in(login2, password);


            //Go to main page with acc2
            MainPage mainPageAcc2 = reloginPage.OpenMainPage();
            //find last letter
            mainPageAcc2.FindAndOpenLastLetter();


            //go to letter page
            LetterPage letterPage = mainPageAcc2.OpenLetterPage();
            //fint letter content
            letterPage.FindLetterText(ref text);

            //verify letter text
            Assert.IsTrue(text.Contains(letterContent));

            //answer message
            letterPage.AnswerMessage(answerMail);

            //go to ReLoginPage and login with acc1
            ReLoginPage reloginPage2 = mainPageAcc2.OpenReLoginPage();
            reloginPage2.Re_Log_in(login, password);


            //Go to main page with acc1
            MainPage mainPageAcc1_1 = reloginPage2.OpenMainPage();
            //find last letter
            mainPageAcc1_1.FindAndOpenLetterAnswer();


            //go to letter page
            LetterPage letterPage2 = mainPageAcc1_1.OpenLetterPage();
            //fint letter content
            letterPage2.FindLetterText(ref text);

            //verify letter answer text
            Assert.IsTrue(text.Contains(answerMail));
        }
    }
}