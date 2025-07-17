using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    class Program
    {

        public static void ClickCheckboxes(string checkboxID, IWebDriver driver)
        {
            IWebElement checkbox = driver.FindElement(By.Id(checkboxID));
            checkbox.Click();
        }

        public static void SelectListItem(string itemID, IWebDriver driver)
        {
            IWebElement selectedItem = driver.FindElement(By.Id(itemID));
            selectedItem.Click();

        }

        //public static void 
        static void Main()
        {

            // Initiate Webdriver
            IWebDriver driver = new ChromeDriver();

            // adding an implicit wait of 20 secs
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // launch the application
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/check-box.php");


        }
    }
}