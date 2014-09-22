//------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace GetHtmlTest
{
    using System;
    using System.Drawing.Imaging;
    using OpenQA.Selenium;
    using OpenQA.Selenium.PhantomJS;

    /// <summary>
    /// Startup class for the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starting point for the application.
        /// </summary>
        /// <param name="args"> The arguments passed in from the console. </param>
        public static void Main(string[] args)
        {
            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
            service.IgnoreSslErrors = true;
            service.LoadImages = false;

            Console.WriteLine("gebruikersnaam");
            string gebruikersnaam = Console.ReadLine();
            Console.WriteLine("wachtwoord");
            string wachtwoord = Console.ReadLine();

            IWebDriver driver = new PhantomJSDriver(service);
            driver.Navigate().GoToUrl("https://mijn.ing.nl/internetbankieren/SesamLoginServlet");

            IWebElement gebruikersnaamElem = driver.FindElement(By.XPath("//div[@id='gebruikersnaam']/descendant::input"));
            gebruikersnaamElem.SendKeys(gebruikersnaam);
            IWebElement wachtwoordElem = driver.FindElement(By.XPath("//div[@id='wachtwoord']/descendant::input"));
            wachtwoordElem.SendKeys(wachtwoord);
            IWebElement button = driver.FindElement(By.CssSelector("button.submit"));
            button.Click();

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("ing.png", ImageFormat.Png);
            System.IO.File.WriteAllText("ing.html", driver.PageSource);

            driver.Quit();

            Console.WriteLine("We are done");
            Console.ReadKey();
        }
    }
}
