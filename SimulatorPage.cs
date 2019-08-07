using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Simudoll.Webfront.Tests
{
    class SimulatorPage
    {
        [FindsBy(How = How.CssSelector, Using = ".panel-heading>p")]
        private IWebElement _simulatorWindowsName;
        public string SimulatorWindowsName => _simulatorWindowsName.Text;
    }
}
