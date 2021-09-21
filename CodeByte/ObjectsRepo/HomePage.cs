using CodeByte.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace CodeByte.ObjectsRepo
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="driver">The Driver.</param>
        public HomePage(IWebDriver driver) => this.driver = driver;

        /// <summary>
        /// Gets element for UserName.
        /// </summary>
        private IWebElement UserName => this.driver.FindElement(By.Name("username"));

        /// <summary>
        /// Gets element for Password.
        /// </summary>
        private IWebElement Password => this.driver.FindElement(By.Name("password"));

        /// <summary>
        /// Gets element for LogicButton.
        /// </summary>
        private IWebElement LogicButton => this.driver.FindElement(By.Name("login"));


        public void ValidateEnterUserNameAndPassword(string UserName, string Password)
        {
        
            IWebElement userName = this.driver.FindElement(By.Name("username"));
            IWebElement password = this.driver.FindElement(By.Name("password"));
            IWebElement loginButton = this.driver.FindElement(By.Name("login"));

            userName.Clear();
            userName.SendKeys(UserName);
            password.Clear();
            password.SendKeys(Password);
            BaseSetupConfiguration.ClickElement(loginButton);
            //this.LogicButton.Click();
        }
    }
}
