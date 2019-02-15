using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.Pages
{
    class Sort4Gb
    {
        private IWebDriver web;

        [FindsBy(How = How.PartialLinkText, Using = "4/")]
        public IList<IWebElement> sort4Gb { get; set; }
    }
}
