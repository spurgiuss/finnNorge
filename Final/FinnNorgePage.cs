using Final.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Page
{
    public class FinnNorgePage : PageBase
    {
        private  IWebElement ChooseCars => driver.FindElement(By.CssSelector(".market - grid__item:nth - child(3) svg"));
        private  IWebElement CarsInNorway => driver.FindElement(By.ClassName("u-display-inline-block u-pv8 u-no-break)"));
        private  IWebElement ChooseMB => driver.FindElement(By.CssSelector(".list:nth-child(4) > li:nth-child(8) label"));
        private  IWebElement ChooseModelA => driver.FindElement(By.CssSelector(".u-ml16 > li:nth-child(2) font > font"));
        private  IWebElement EnterYearFrom => driver.FindElement(By.CssSelector("form:nth-child(15) .form-grid__unit:nth-child(1) input"));
        private  IWebElement EnterYearTo => driver.FindElement(By.CssSelector("form:nth-child(15) .u-ph0 input"));
        private  IWebElement ChooseCombi5Door => driver.FindElement(By.CssSelector(".list:nth - child(33) > li:nth - child(1) label"));
        private  IWebElement ClickSearch => driver.FindElement(By.CssSelector("form:nth-child(15) .button"));
        public  IWebElement AddAdConcentCookies => driver.FindElement(By.PartialLinkText("Jeg forstår"));
   

        public FinnNorgePage(IWebDriver webDriver) : base(webDriver) { }

        public FinnNorgePage GoToFinnPage()
        {
            driver.Url = "http://www.finn.no";
 
            return this;
        }

        public FinnNorgePage AddAdConcentCookiess()
        {
            driver.Manage().Cookies.AddCookie(new Cookie(

               "s_sq",
               "%5B%5BB%5D%5D",
               "/",
               ".finn.no",
                  DateTime.Now.AddDays(5)
               ));


            driver.Navigate().Refresh();
            return this;

        }

        public FinnNorgePage AcceptCookies()
        {
            AddAdConcentCookies.Click();
            return this;
        }


        public  FinnNorgePage ChooseVehicles()
        {
           // var wait = GetWait(7);
            ChooseCars.Click();

            return this;                           
        }

        public FinnNorgePage ChooseInNorge()
        {
            CarsInNorway.Click();

            return this;
        }

        public FinnNorgePage SelectCar()
        {
            if (!ChooseMB.Selected)
                ChooseMB.Click();

            return this;
        }

        public  FinnNorgePage SelectModel()
        {
            if (!ChooseModelA.Selected)
                ChooseModelA.Click();

            return this;
        }

        public FinnNorgePage InputYearFrom(string EnteredYearFrom)
        {
            EnterYearFrom.Clear();
            EnterYearFrom.SendKeys(EnteredYearFrom);
            return this;
        }
        public FinnNorgePage InputYearTo(string EnteredYearTo)
        {
            EnterYearTo.Clear();
            EnterYearTo.SendKeys(EnteredYearTo);

            return this;
        }

        public FinnNorgePage ChooseDoorCount()
        {
            if (!ChooseCombi5Door.Selected)
                ChooseCombi5Door.Click();

            return this;
        }

        public FinnNorgePage ClickSearchButton()
        {
            ClickSearch.Click();

            return this;

        }

    }
}
