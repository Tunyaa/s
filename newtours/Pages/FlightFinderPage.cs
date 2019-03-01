using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace newtours.Pages
{
    class FlightFinderPage
    {
        public IWebDriver driver;
        

        [FindsBy(How = How.Name, Using = "tripType")]
        public IList<IWebElement> type { get; set; }

        [FindsBy(How = How.Name, Using = "passCount")]
        public IWebElement passengers { get; set; }
        
        [FindsBy(How = How.Name, Using = "fromPort")]
        public IWebElement departFrom { get; set; }

        [FindsBy(How = How.Name, Using = "fromMonth")]
        public IWebElement onMDate { get; set; }

        [FindsBy(How = How.Name, Using = "fromDay")]
        public IWebElement onDDate { get; set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        public IWebElement arrivingIn { get; set; }

        [FindsBy(How = How.Name, Using = "toMonth")]
        public IWebElement toMonth { get; set; }

        [FindsBy(How = How.Name, Using = "toDay")]
        public IWebElement toDay { get; set; }

        [FindsBy(How = How.Name, Using = "servClass")]
        public IList<IWebElement> serviceClass { get; set; }

        [FindsBy(How = How.Name, Using = "airline")]
        public IWebElement airline { get; set; }

        [FindsBy(How = How.Name, Using = "findFlights")]
        public IWebElement continueB { get; set; }
    }
}
