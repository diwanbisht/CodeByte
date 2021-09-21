using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeByte.Core
{

    public class SeleniumContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeleniumContext"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public SeleniumContext()
        {


        }

        /// <summary>
        /// Gets the web driver.
        /// </summary>
        /// <value>The web driver.</value>
        public IWebDriver WebDriver { get; private set; }
    }
}