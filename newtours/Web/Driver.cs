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
            select = new SelectElement(flightFinder.passengers);
            select.SelectByIndex(uInputs.passengers);
            select = new SelectElement(flightFinder.departFrom);
            select.SelectByText(uInputs.departFrom);
            select = new SelectElement(flightFinder.onMDate);
            select.SelectByText(uInputs.OnMonth);
            select = new SelectElement(flightFinder.onDDate);
            select.SelectByText(uInputs.OnDay);
            select = new SelectElement(flightFinder.arrivingIn);
            select.SelectByText(uInputs.arrivIn);
            select = new SelectElement(flightFinder.toMonth);
            select.SelectByText(uInputs.returnMonth);
            select = new SelectElement(flightFinder.toDay);
            select.SelectByText(uInputs.returnDay);
            flightFinder.serviceClass.ElementAt(uInputs.serviceClass).Click();
            select = new SelectElement(flightFinder.airline);
            select.SelectByText(uInputs.airline);
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
            select = new SelectElement(bookAFlight.mealPas1);
            select.SelectByText(uInputs.mealPas1);
            bookAFlight.fNamePas2.SendKeys(uInputs.firstNamePas2);
            bookAFlight.lNamePas2.SendKeys(uInputs.lastNamePas2);
            select = new SelectElement(bookAFlight.mealPas2);
            select.SelectByText(uInputs.mealPas2);
            select = new SelectElement(bookAFlight.cardType);
            select.SelectByText(uInputs.cardType);
            bookAFlight.cardNum.SendKeys(uInputs.cardNumber);
            select = new SelectElement(bookAFlight.cardDM);
            select.SelectByText(uInputs.cardExM);
            select = new SelectElement(bookAFlight.cardDY);
            select.SelectByText(uInputs.cardExY);
            bookAFlight.cardFName.SendKeys(uInputs.cardFirstName);
            bookAFlight.cardMName.SendKeys(uInputs.cardMiddleName);
            bookAFlight.cardLName.SendKeys(uInputs.cardLastName);

        }
        
    }
}
