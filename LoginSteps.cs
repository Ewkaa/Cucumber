using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using CucumberTest.pages;
using TechTalk.SpecFlow;

namespace CucumberTest
{
    [Binding]
    public class PageSteps
    {
        private readonly IWebDriver _nDriver;
        private readonly IWait<IWebDriver> _Wait;
        private KomputronikHome _komputronikHome;
        

        public PageSteps()
        {
            _nDriver = new ChromeDriver();
            _Wait = new WebDriverWait(_nDriver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(100)
            };
            _nDriver.Manage().Window.Maximize();
        }
        [Given (@"User navigates to komputronik website")]
        public void GivenUserNavigatesToKomputronikWebsite()
        {
            _nDriver.Navigate().GoToUrl("https://www.komputronik.pl/");
            _komputronikHome = new KomputronikHome(_nDriver);

        }

        [When (@"User clicks on the Loguj button on homepage")]
        public void WhenUserClicksOnTheLogujButtonOnHomepage()
        {
            _komputronikHome.LogujButtonClick();
        }

        [When(@"User enters a valid username")]
        public void WhenUserEntersAValidUsername()
        {
            _komputronikHome.EnterUsername();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User enters a valid password ")]
        public void WhenUserEntersAValidPassword()
        {
            _komputronikHome.EnterPassword();
            System.Threading.Thread.Sleep(2000);


        }
        [When(@"User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {

            _komputronikHome.LoginButtonClick();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"User should be taken to the successful login page")]
        public void ThenUserShouldBeTakenToTheSuccessfulLoginPage()
        {
            _komputronikHome.Asercja();
        }


        [AfterScenario]
        public void QuitBrowser()
        {
            _nDriver.Quit();
        }

    }

}