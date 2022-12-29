using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Maveric.Salesforce
{
    public class Task4
    {
        static void Main(string[] args)

        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";



            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");

            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            dropdown1.SelectByText("IT Manager");


            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");

            SelectElement dropdown2 = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            dropdown2.SelectByText("101 - 500 employees");

            driver.FindElement(By.Name("UserPhone")).SendKeys("");

            SelectElement dropdown3 = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));

            dropdown3.SelectByText("United Kingdom");

            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();



        }
    }
}