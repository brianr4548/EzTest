using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EzTest;

namespace SeleniumTests
{
    class playground
    {
        static void Main()
        {


            // Initiate Webdriver
            IWebDriver driver = new ChromeDriver();

            // adding an implicit wait of 20 secs
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // launch the application
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/check-box.php");

            ClickEvents.ClickByID("c_bs_1", driver);


        }
    }
}