using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;

namespace newtours.Pages
{
    class LoginPage
    {
        private IWebDriver driver;
        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement userNameField { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement passwordField { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement signIn { get; set; }

    }
}
