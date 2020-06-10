using _0602new_tests.tests;
using Final.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Tests
{
    public class FinnNorgeTest : TestBase

    {
        [Test]
        public static void SearchTest()
        {
            finnNorge
                       .GoToFinnPage()
                       .AddAdConcentCookiess()
                       .ChooseVehicles()
                       .ChooseInNorge()
                       .SelectCar()
                       .SelectModel()
                       .InputYearFrom("2018")
                       .InputYearTo("2020")
                       .ChooseDoorCount()
                       .ClickSearchButton();
            

        }

    }
}
