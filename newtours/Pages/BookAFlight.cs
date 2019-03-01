using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace newtours.Pages
{
    class BookAFlight
    {
        public IWebDriver driver;

        [FindsBy(How = How.Name, Using = "passFirst0")]
        public IWebElement fNamePas1 { get; set; }

        [FindsBy(How = How.Name, Using = "passLast0")]
        public IWebElement lNamePas1{ get; set; }

        [FindsBy(How = How.Name, Using = "pass.0.meal")]
        public IWebElement mealPas1 { get; set; }

        [FindsBy(How = How.Name, Using = "passFirst1")]
        public IWebElement fNamePas2 { get; set; }

        [FindsBy(How = How.Name, Using = "passLast1")]
        public IWebElement lNamePas2 { get; set; }

        [FindsBy(How = How.Name, Using = "pass.1.meal")]
        public IWebElement mealPas2 { get; set; }

        [FindsBy(How = How.Name, Using = "creditCard")]
        public IWebElement cardType { get; set; }

        [FindsBy(How = How.Name, Using = "creditnumber")]
        public IWebElement cardNum { get; set; }

        [FindsBy(How = How.Name, Using = "cc_exp_dt_mn")]
        public IWebElement cardDM { get; set; }

        [FindsBy(How = How.Name, Using = "cc_exp_dt_yr")]
        public IWebElement cardDY { get; set; }

        [FindsBy(How = How.Name, Using = "cc_frst_name")]
        public IWebElement cardFName { get; set; }

        [FindsBy(How = How.Name, Using = "cc_mid_name")]
        public IWebElement cardMName { get; set; }

        [FindsBy(How = How.Name, Using = "cc_last_name")]
        public IWebElement cardLName { get; set; }

        [FindsBy(How = How.Name, Using = "billAddress1")]
        public IWebElement bilAddress { get; set; }

        [FindsBy(How = How.Name, Using = "billCity")]
        public IWebElement bilCity { get; set; }

        [FindsBy(How = How.Name, Using = "billState")]
        public IWebElement bilState { get; set; }

        [FindsBy(How = How.Name, Using = "billZip")]
        public IWebElement bilZip { get; set; }

        [FindsBy(How = How.Name, Using = "billCountry")]
        public IWebElement delCountry { get; set; }

        [FindsBy(How = How.Name, Using = "delAddress1")]
        public IWebElement delAddress { get; set; }

        [FindsBy(How = How.Name, Using = "delCity")]
        public IWebElement delCity { get; set; }

        [FindsBy(How = How.Name, Using = "delState")]
        public IWebElement delState { get; set; }

        [FindsBy(How = How.Name, Using = "delZip")]
        public IWebElement delZip { get; set; }

        [FindsBy(How = How.Name, Using = "delCountry")]
        public IWebElement delCountru { get; set; }
    }
}
