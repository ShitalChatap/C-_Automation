using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            driver.FindElement(By.XPath("//a[text()='Try Free']")).Click();
        }
    }
}