using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Task2
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";//set //navigate to the url


            // Contact Information
   
            driver.FindElement(By.Name("firstName")).SendKeys("shital");
            driver.FindElement(By.Name("lastName")).SendKeys("Chatap");
            driver.FindElement(By.Name("phone")).SendKeys("1276234589");
            driver.FindElement(By.Name("userName")).SendKeys("shital@123");

            //Mailing Information
            driver.FindElement(By.Name("address1")).SendKeys("xyz");
            driver.FindElement(By.Name("city")).SendKeys("pune");
            driver.FindElement(By.Name("state")).SendKeys("maharastra");
            driver.FindElement(By.Name("postalCode")).SendKeys("1234");
            

            driver.FindElement(By.Name("country")).SendKeys("india");

            //User Information
            driver.FindElement(By.Name("email")).SendKeys("shital@123");
            driver.FindElement(By.Name("password")).SendKeys("shital@123s");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("shital@123s");

            driver.FindElement(By.Name("submit")).Click();



        }
    }
}
