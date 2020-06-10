using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   public class PageBase
    {
        protected static IWebDriver driver;

        public PageBase(IWebDriver webDriver)
        {
            driver = webDriver;
        }
 
        public WebDriverWait GetWait(int seconds = 4)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
