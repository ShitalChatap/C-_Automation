using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synchronization
{
    public class MediBuddy
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.medibuddy.in/";
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
            driver.FindElement(By.XPath("//div[text()='I have an Insurance/Corporate Account']")).Click();
            driver.FindElement(By.XPath("//div[text()='Login using Username & Password']")).Click();
            driver.FindElement(By.Name("userName")).SendKeys("john");
            driver.FindElement(By.XPath("//button[text()='Proceed']")).Click();
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.XPath("//span[text()='Show password']")).Click();
            driver.FindElement(By.XPath("//button[text()='Log in']")).Click();




        }
    }
}
