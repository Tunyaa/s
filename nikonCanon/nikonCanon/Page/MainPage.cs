using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace nikonCanon.Page
{
    class MainPage
    {
        private IWebDriver web;
        [FindsBy(How = How.XPath, Using = "//div[1]/div[2]/ul[1]/li[1]/a[1]")]
        public IWebElement AllCams { get; set; }
    }
}
