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

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";


            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");

            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            dropdown1.DeselectByText("IT_Manager_AP");


            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");
            //SelectElement selectEmployee= new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            //selectEmployee.SelectByText("101 - 500 employees");
            SelectElement dropdown2 = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            dropdown2.SelectByText("101 - 500 employees");

            driver.FindElement(By.Name("UserPhone")).SendKeys("");

            SelectElement dropdown3 = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));

             dropdown3.SelectByText("United Kingdom");
           
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
           // driver.FindElement(By.ClassName("checkbox-ui"


        }
    }
}