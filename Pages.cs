using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace Simudoll.Webfront.Tests
{
    public static class Pages
    {
        public static HomePage HomePage(Browser browser)
        {
            var homePage = new HomePage(browser);
            PageFactory.InitElements(browser.Driver, homePage);
            return homePage;
        }
    }
}

