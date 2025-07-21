using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzTest
{
    internal class ClickEvents
    {
        public static void ClickByID(string elementID, IWebDriver driver)
        {

            IWebElement checkbox = driver.FindElement(By.Id(elementID));
            checkbox.Click();
        }

        public static void ClickByXpath(string Xpath, IWebDriver driver)
        {
            IWebElement a = driver.FindElement(By.XPath(Xpath));
            a.Click();

        }
        public static void TestFieldInput(string elementID, IWebDriver driver, string textInput)
        {
            IWebElement textField = driver.FindElement(By.Id(elementID));
            textField.Click();
            textField.SendKeys(textInput);
        }
    }
}
