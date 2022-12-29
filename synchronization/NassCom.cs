using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace synchronization
{
    public class NassCom
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://nasscom.in/";
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
            driver.FindElement(By.XPath("//li[text()='register']")).Click();
            driver.FindElement(By.XPath("//input[@name='field_fname_reg[0][value]']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@name='field_lname[0][value]']")).SendKeys("pass");
            driver.FindElement(By.XPath("//input[@name='mail']")).SendKeys("admin@gmail.com");
            driver.FindElement(By.XPath("//input[@name='field_company_name_registration[0][value]']")).SendKeys("Google");
            SelectElement business = new SelectElement(driver.FindElement(By.XPath("//select[@id=\"edit-field-business-focus-reg\"]")));
            business.SelectByText("IT Consulting");
            driver.FindElement(By.XPath("//input[@id='edit-submit--2']")).Click();
        }
    }
}
