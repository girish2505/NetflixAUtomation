using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetflixAutomation.DoActions
{
    public class Action
    {
        public static void EnterCedentials(IWebDriver driver)
        {
            driver.FindElement(By.Name("userLoginId")).SendKeys(ExcelOperations.ReadData(1, "username")); ;
            System.Threading.Thread.Sleep(10000);

            driver.FindElement(By.Name("password")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(10000);

            driver.FindElement(By.XPath("//*[@id='appMountPoint']/div/div[3]/div/div/div[1]/form/button")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
