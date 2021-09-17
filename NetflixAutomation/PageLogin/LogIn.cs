using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetflixAutomation.PageLogin
{
    class LogIn
    {
        [FindsBy(How = How.Name, Using = "userLoginId")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@id='appMountPoint']/div/div[3]/div/div/div[1]/form/button")]
        [CacheLookup]
        public IWebElement sigin;
    }
}
