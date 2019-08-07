using System;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Simudoll.Webfront.Tests
{
    public class Browser
    {
        readonly IWebDriver _webDriver;

        public Browser(string browserType = "Chrome")
        {
            var currentDir = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            switch (browserType)
            {
                case "Firefox":
                    var driverDir = new DirectoryInfo(Path.Combine(currentDir, @"..\..\..\packages\WebDriver.GeckoDriver.0.16.1\content")).FullName;
                    _webDriver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(driverDir));
                    break;
                case "Chrome":
                    driverDir = new DirectoryInfo(Path.Combine(currentDir, @"..\..\..\packages\Selenium.WebDriver.ChromeDriver.2.30.0.1\driver\win32")).FullName;
                    _webDriver = new ChromeDriver(driverDir);
                    break;
                case "IE":
                    _webDriver = new InternetExplorerDriver();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public string Title => _webDriver.Title;

        public IWebDriver Driver => _webDriver;

        public void GoTo(string url)
        {
            _webDriver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            _webDriver.Url = url;
        }

        public void Close() => _webDriver?.Close();

        public void Dispose() => _webDriver?.Quit();
    }
}