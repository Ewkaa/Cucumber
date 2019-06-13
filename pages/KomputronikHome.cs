using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace CucumberTest.pages
{
    class KomputronikHome
    {

        public IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = ("//a[@class='btn2 btn2-transparent btn2-h0']"))]
        private IWebElement site;
        
        [FindsBy(How = How.XPath,Using = "//a[@class='btn2 btn2-transparent account at-login']")]
        IWebElement loginLink;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='wpisz login']")]
        IWebElement usernameTextBox;

        [FindsBy(How = How.XPath, Using= "//input[@placeholder='wpisz hasło']")]
        IWebElement passwordTextBox;

        [FindsBy(How = How.XPath, Using= "//button[@name='button']")]
        IWebElement loginButton;

    

        public void LoginButtonClick()
        {
            loginButton.Click();
        }

        public void EnterPassword()
        {
            passwordTextBox.SendKeys("Abcde123");
        }

        public void EnterUsername()
        {
            usernameTextBox.SendKeys("kalemba.ewelinak@gmail.com");
        }
        
        public void LogujButtonClick()
        {
            loginLink.Click();
        }

        public void Asercja()
        {
            Assert.AreEqual(true, site.Displayed);
        }

        public KomputronikHome(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }

}



   
