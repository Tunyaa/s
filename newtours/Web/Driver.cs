using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using newtours.Inputs;
using newtours.Pages;
using NUnit.Framework;
namespace newtours.Web
{
    class Driver
    {
        IWebDriver driver;
        UInputs uInputs = new UInputs();
        SelectElement select;
        
        public void Chrome()
        {
           driver = new ChromeDriver();
        }
        public void ChromeUrl()
        {
            driver.Url = uInputs.url;
        }
        
        public void Login()
        {
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.userNameField.Clear();
            loginPage.userNameField.SendKeys(uInputs.userName);
            loginPage.passwordField.Clear();
            loginPage.passwordField.SendKeys(uInputs.password);
            loginPage.signIn.Click();
        }
        public void FlightFinder()
        {
            
            var flightFinder = new FlightFinderPage();
            PageFactory.InitElements(driver, flightFinder);
            flightFinder.type.ElementAt(uInputs.type).Click();
            SelectByText(flightFinder.passengers, uInputs.passengers);
            SelectByText(flightFinder.departFrom, uInputs.departFrom);
            SelectByText(flightFinder.onMDate, uInputs.OnMonth);
            SelectByText(flightFinder.onDDate, uInputs.OnDay);
            SelectByText(flightFinder.arrivingIn, uInputs.arrivIn);
            SelectByText(flightFinder.toMonth, uInputs.returnMonth);
            SelectByText(flightFinder.toDay, uInputs.returnDay);
            flightFinder.serviceClass.ElementAt(uInputs.serviceClass).Click();
            SelectByText(flightFinder.airline, uInputs.airline);
            flightFinder.continueB.Click();
        }
        public void FlightSelect()
        {
            var flightSelect = new SelectFlight();
            PageFactory.InitElements(driver, flightSelect);
            flightSelect.flightOut.ElementAt(uInputs.flightOut).Click();
            flightSelect.flightIn.ElementAt(uInputs.flightIn).Click();
            flightSelect.continueB.Click();
        }
        public void BookAFlight()
        {
            var bookAFlight = new BookAFlight();
            PageFactory.InitElements(driver, bookAFlight);
            bookAFlight.fNamePas1.SendKeys(uInputs.firstNamePas1);
            bookAFlight.lNamePas1.SendKeys(uInputs.lastNamePas1);
            SelectByText(bookAFlight.mealPas1, uInputs.mealPas1);
            bookAFlight.fNamePas2.SendKeys(uInputs.firstNamePas2);
            bookAFlight.lNamePas2.SendKeys(uInputs.lastNamePas2);
            SelectByText(bookAFlight.mealPas2, uInputs.mealPas2);
            SelectByText(bookAFlight.cardType, uInputs.cardType);
            bookAFlight.cardNum.SendKeys(uInputs.cardNumber);
            SelectByText(bookAFlight.cardDM, uInputs.cardExM);
            SelectByText(bookAFlight.cardDY, uInputs.cardExY);
            bookAFlight.cardFName.SendKeys(uInputs.cardFirstName);
            bookAFlight.cardMName.SendKeys(uInputs.cardMiddleName);
            bookAFlight.cardLName.SendKeys(uInputs.cardLastName);
            bookAFlight.continueB.Click();
        }
        
        public void Close()
        {
            driver.Quit();
        }
        public static void SelectByText(IWebElement element, String str)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(str);
        }
    }
}
