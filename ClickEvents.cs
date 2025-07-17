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
        public static void ClickByID(string checkboxID, IWebDriver driver)
        {

            IWebElement checkbox = driver.FindElement(By.Id(checkboxID));
            checkbox.Click();
        }

        //public static void ClickByClassName(string itemClass, IWebDriver driver) 
        //{ 
      
        //    IWebElement selectedItem = driver.FindElement(By.ClassName(itemClass));
        //    selectedItem.Click();

        //}

        //public static void ClickTextfield()
        //{

        //}
        //public static void TestFieldInput()
        //{

        //}
    }
}
