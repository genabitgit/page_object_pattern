using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Simudoll.Webfront.Tests
{
    class ContactPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/ul/li[3]/a")]
        private IWebElement _contactButton;
        public string ContactButton => _contactButton.Text;
    }
}
