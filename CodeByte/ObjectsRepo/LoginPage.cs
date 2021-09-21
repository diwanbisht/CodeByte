using CodeByte.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace CodeByte.ObjectsRepo
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="DashBoardHomePage"/> class.
        /// </summary>
        /// <param name="driver">The Driver.</param>
        public LoginPage(IWebDriver driver) => this.driver = driver;

        /// <summary>
        /// Gets element for UserName.
        /// </summary>
        private IWebElement UserName => this.driver.FindElement(By.Id("txtUsername"));

        /// <summary>
        /// Gets element for Password.
        /// </summary>
        private IWebElement Password => this.driver.FindElement(By.Id("txtPassword"));

        /// <summary>
        /// Gets element for LogicButton.
        /// </summary>
        private IWebElement LogicButton => this.driver.FindElement(By.Id("btnLogin"));

        /// <summary>
        /// Gets element for Invalid Login Span.
        /// </summary>
        private IWebElement InvalidLogin => this.driver.FindElement(By.XPath("//span[contains(text(),'Invalid credentials')]"));



        public void ValidateEnterUserNameAndPassword(string UserName, string Password)
        {
            this.UserName.Clear();
            this.UserName.SendKeys(UserName);
            this.Password.Clear();
            this.Password.SendKeys(Password);
            BaseSetupConfiguration.ClickElement(this.LogicButton);
            //new DashBoardHomePage(this.driver).UserLogOut();
        }

        public string ValidateInvalidLogin(string UserName, string Password)
        {
            this.UserName.Clear();
            this.UserName.SendKeys(UserName);
            this.Password.Clear();
            this.Password.SendKeys(Password);
            BaseSetupConfiguration.ClickElement(this.LogicButton);
            return this.InvalidLogin.Text;
        }
    }
}
