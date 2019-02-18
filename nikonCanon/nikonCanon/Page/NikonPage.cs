using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace nikonCanon.Page
{
    class NikonPage
    {
        private IWebDriver web;
        [FindsBy(How = How.PartialLinkText, Using = "18-55")]
        public IList<IWebElement> nikonCams { get; set; }
    }
}
