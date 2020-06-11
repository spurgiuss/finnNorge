using _0602new_tests.tests;
using Final.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Final.Tests
{
    public class FinnNorgeTest : TestBase

    {
        [Test]
        public static void SearchTest()
        {
            _finnNorge
                       .GoToFinnPage()
                       .AddAdConcentCookies()
                       .ChooseVehicles()
                       .ChooseInNorge()
                       .SelectCar()
                       .SelectModel()
                       .InputYearFrom("2018")
                       .InputYearTo("2020")
                       .ChooseDoorCount()
                       .ClickSearchButton()
                       .SortByElements(SortByResults.PriceLowHigh)
                       ;


        }
        [Test]
        public static void TestsScr()
        {
            var assemblyName = Assembly.GetExecutingAssembly().Location;
            var directoryName = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(assemblyName)));

        }

    }
}
