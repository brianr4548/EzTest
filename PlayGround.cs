using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EzTest;

namespace SeleniumTests
{
    class Playground
    {
        static void Main()
        {


            // Initiate Webdriver
            IWebDriver driver = new ChromeDriver();

            // adding an implicit wait of 20 secs
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // launch the application
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/check-box.php");

            // write code below this line ==================================================================

            ClickEvents.ClickByXpath("//*[@id=\"navMenus\"]/li[1]/a", driver);
            ClickEvents.TestFieldInput("fullname", driver, "Brian");


            




        }
    }
}