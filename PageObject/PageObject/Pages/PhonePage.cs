using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.Pages
{
    class PhonePage
    {
        private IWebDriver web;

        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/a")]
        public IList<IWebElement> PhoneFields { get; set; }
    }
}
