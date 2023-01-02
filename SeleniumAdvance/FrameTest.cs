using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumAdvance
{
    public class FrameTest
    {
        [Test]
        public void Demo1Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

           // driver.SwitchTo().Frame(driver.FindElement(By.XPath("")));
                //enter userid conitnue
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("kevin123");

           //switch back to main html

        }
    }
}
