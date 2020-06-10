
using Final.Drivers;
using Final.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602new_tests.tests
{
    public class TestBase 
    {
        public static IWebDriver driver;
        public static FinnNorgePage finnNorge;

        [OneTimeSetUp]

        public static void SetupChrome()
        {
            driver = AllDrivers.GetChromeDriver();

            finnNorge = new FinnNorgePage(driver);

        }

        //[TearDown]
        //public static void SingleTestTearDown()
        //{
        //    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
        //    {
        //        MyScreenshot.MakePhoto(driver);
        //    }
        //}

        [OneTimeTearDown]
        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}

