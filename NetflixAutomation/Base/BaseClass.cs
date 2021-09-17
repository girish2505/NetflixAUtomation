using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetflixAutomation.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.netflix.com/in/login";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
