﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeByte.Core
{

    public class BaseSetupConfiguration
    {
        public IWebDriver driver { get; set; }
        public TestContext TestContext { get; set; }

        public BaseSetupConfiguration()
        {
            this.driver = driver;
        }

        [TestInitialize]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
            var BaseUrl = ReadExcelData.ReadExcelRowByRow(2);
            // var BrowserType = ReadExcelData.ReadExcelRowByRow(2);
            driver.Navigate().GoToUrl(BaseUrl["BaseUrl"].ToString());
        }


        [TestCleanup]
        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }

         public IWebDriver Driver
         {
             get { return driver; }
         }


        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }


    }
}