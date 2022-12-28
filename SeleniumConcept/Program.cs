using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class Program
    {
        static void Main(string[] args) 
        {
            ChromeDriver driver = new ChromeDriver();

            //driver=new EndOfStreamException();

            driver.Url="https://github.com/login";//set //navigate to the url 
           string title=driver.Title;//get the current title
            Console.WriteLine(title); 
            Console.WriteLine(driver.Url);//get current url
            
            //get the page source and print it 
           Console.WriteLine(driver.PageSource);

        }
    }
}