using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;

namespace Maveric.Synchonization
{
    public class GoTo
    {
        static void Main(string[] args)

        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            driver.Url = "  https://www.goto.com/meeting/";
            driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();



            Actions actions = new Actions(driver);
            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch
            {

            }
            driver.FindElement(By.LinkText("Try Free")).Click();
            driver.FindElement(By.XPath("//input[@name='FirstName']")).SendKeys("John");
            driver.FindElement(By.XPath("//input[@name='LastName']")).SendKeys("wick");
            driver.FindElement(By.XPath("//input[@name='Email']")).SendKeys("john@gmail.com");
            SelectElement Companysize = new SelectElement(driver.FindElement(By.XPath("//select[@id='CompanySize']")));
            Companysize.SelectByText("10 - 99");
            driver.FindElement(By.Id("//button[text()='Start My Trial']")).Click();
            driver.FindElement(By.Id("contact-number")).SendKeys("1A");
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();
            string err = driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(err);

        }
        }
    }

    




        
    
