﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Final.Tools
{
    public static class MyScreenshot
    {
        public static void MakePhoto(IWebDriver webDriver)
        {
            Screenshot myScreenshot = webDriver.TakeScreenshot();
            string screenshotDirectory =
                Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

            string screenshotFolder = Path.Combine(screenshotDirectory, "TestScreenshots");
            Directory.CreateDirectory(screenshotFolder);

            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH:mm}.png";
            string screenshotPath = Path.Combine(screenshotFolder, screenshotName);

            myScreenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }
    }
}