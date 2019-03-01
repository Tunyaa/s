﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace newtours.Pages
{
    class SelectFlight
    {
        public IWebDriver driver;
        [FindsBy(How = How.Name, Using = "outFlight")]
        public IList<IWebElement> flightOut { get; set; }

        [FindsBy(How = How.Name, Using = "inFlight")]
        public IList<IWebElement> flightIn { get; set; }

        [FindsBy(How = How.Name, Using = "reserveFlights")]
        public IWebElement continueB { get; set; }
    }
}