using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{


    public class MultiplTabsTest
    {
        [Test]
        public void PhpMyAdminTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.LinkText("phpMyAdmin")).Click();
            ReadOnlyCollection<string> windows = driver.WindowHandles;

            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);




            driver.FindElement(By.LinkText("phpMyAdmin »")).Click();
            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("Shital");
            //enter password as admin
            driver.FindElement(By.Id("input_password")).SendKeys("665565");
            //click on login
            driver.FindElement(By.Id("input_go")).Click();



           // driver.Close();//check what is happing
            //Console.WriteLine(driver.Title); 



        }
    }
}

