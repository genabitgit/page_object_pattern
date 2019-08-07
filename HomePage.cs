using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Simudoll.Webfront.Tests
{
    public class HomePage
    {
        Browser _browser;
        WebDriverWait _wait;
        Actions _actions;
        static readonly string _url = "http://simudoll.com";
        private static readonly string _pageTitle = "AstralRobotics";

        [FindsBy(How = How.LinkText, Using = "Simulator")]
        private IWebElement simulatorButtonLink;

        public HomePage(Browser browser)
        {
            _browser = browser;
            _wait = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(10));
            _actions = new Actions(browser.Driver);
        }

        public void GoTo() => _browser.GoTo(_url);

        public bool IsAt() => _browser.Title == _pageTitle;

        public void SelectSimulatorPage(string simulatorButton)
        {
            simulatorButtonLink.Click();
        }

      

        public bool IsAtContactButton(string button)
        {
            var contactButton = new ContactPage();
            PageFactory.InitElements(_browser.Driver, contactButton);
            return contactButton.ContactButton == button;
        }

        public bool IsAtSimulatorPage(string simulatorWindowsName)
        {
            var simulatorPage = new SimulatorPage();
            PageFactory.InitElements(_browser.Driver, simulatorPage);
            return simulatorPage.SimulatorWindowsName == simulatorWindowsName;
        }


    }
}
