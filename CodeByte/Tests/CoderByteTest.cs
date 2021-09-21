using CodeByte.Core;
using CodeByte.ObjectsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CodeByte
{
    [TestClass]
        public class CoderByteTest : BaseSetupConfiguration
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePageSteps"/> class.
        /// </summary>
        /// <param name="baseSetupConfiguration">The Selenium context.</param>
        /*    public CoderByteTest(BaseSetupConfiguration baseSetupConfiguration) 
                : base()
            {
                this.homePage = new HomePage(this.Driver);
            }*/

        [TestMethod]
        public void ValidateValidUserLogin()
        {
            Dictionary<String, String> dicValues = ReadExcelData.ReadExcelRowByRow(2);
            string UserName = dicValues["UserName"];
            string Password = dicValues["Password"];
            //HomePage homePage = new HomePage(this.Driver);
            new HomePage(this.Driver).ValidateEnterUserNameAndPassword(UserName, Password);
           // homePage.ValidateEnterUserNameAndPassword(UserName, Password);
            string pageTitle = this.driver.Title;
            Assert.AreEqual("Adactin.com - Hotel Reservation System", pageTitle,   "Page title is not matched");
        }



        [TestMethod]
        public void ValidateInValidUserLogin()
        {

            Dictionary<String, String> dicValues = ReadExcelData.ReadExcelRowByRow(2);
            string UserName = dicValues["UserName"];
            string Password = dicValues["Password"];

            /*IWebElement userName = this.driver.FindElement(By.Name("username"));
            IWebElement password = this.driver.FindElement(By.Name("password"));
            IWebElement loginButton = this.driver.FindElement(By.Name("login"));

           userName.SendKeys(UserName);
           password.SendKeys(Password);*/
            //loginButton.Click();


        }

        [TestMethod]
        public void ValidateLogin()
        {

            Dictionary<String, String> dicValues = ReadExcelData.ReadExcelRowByRow(2);
            string UserName = dicValues["UserName"];
            string Password = dicValues["Password"];

            /* IWebElement userName = this.driver.FindElement(By.Name("username"));
             IWebElement password = this.driver.FindElement(By.Name("password"));
             IWebElement loginButton = this.driver.FindElement(By.Name("login"));

             userName.SendKeys(UserName);
             password.SendKeys(Password);
             loginButton.Click();*/


        }
    }
}
