
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Task1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";//set //navigate to the url 


            driver.FindElement(By.Id("customer.firstName")).SendKeys("Shital");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("Chatap");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("Xyz,pune,maharastra");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("pune");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharastra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("xyz");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("78745364343");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("243");



            driver.FindElement(By.Id("customer.username")).SendKeys("shitalchatap");
            driver.FindElement(By.Id("customer.password")).SendKeys("shital@123");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("shital@123");
            driver.FindElement(By.ClassName("button")).Click();





        }
    }
}
