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
using newtours.Tests;

namespace newtours.Web
{
    class Driver
    {
        
        IWebDriver driver;
        UInputs uInputs = new UInputs();
        TestsInp test = new TestsInp();
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
            Assert.AreEqual(driver.Title, test.findTitle);
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
            Assert.AreEqual(driver.Title, test.selectTitle);
            Assert.AreEqual(flightSelect.departTo.Text, test.selectDep);
            Assert.AreEqual(flightSelect.DepatrDate.Text, test.selectDepDate);
            Assert.AreEqual(flightSelect.returnTo.Text, test.selectRet);
            Assert.AreEqual(flightSelect.returnDate.Text, test.selectRetDate);
            flightSelect.flightOut.ElementAt(uInputs.flightOut).Click();
            flightSelect.flightIn.ElementAt(uInputs.flightIn).Click();
            flightSelect.continueB.Click();
        }
        
        public void BookAFlight()
        {
            var bookAFlight = new BookAFlight();
            PageFactory.InitElements(driver, bookAFlight);
            Assert.AreEqual(driver.Title, test.bookTitle);
            Assert.AreEqual(bookAFlight.depTo.ElementAt(0).Text, test.bookDep);
            Assert.AreEqual(bookAFlight.depTo.ElementAt(1).Text, test.bookDepDate);
            Assert.AreEqual(bookAFlight.flightTable.ElementAt(0).Text, test.bookDepFlight);
            Assert.AreEqual(bookAFlight.classTable.ElementAt(0).Text, test.bookDepClass);
            Assert.AreEqual(bookAFlight.priceTable.ElementAt(0).Text, test.bookDepPrice);
            Assert.AreEqual(bookAFlight.flightTable.ElementAt(1).Text, test.bookRet);
            Assert.AreEqual(bookAFlight.classTable.ElementAt(1).Text, test.bookRetDate);
            Assert.AreEqual(bookAFlight.flightTable.ElementAt(3).Text, test.bookRetFlight);
            Assert.AreEqual(bookAFlight.classTable.ElementAt(3).Text, test.bookRetClass);
            Assert.AreEqual(bookAFlight.priceTable.ElementAt(2).Text, test.bookRetPrice);
            Assert.AreEqual(bookAFlight.flightTable.ElementAt(5).Text, test.bookPassengers);
            Assert.AreEqual(bookAFlight.flightTable.ElementAt(7).Text, test.bookTaxes);
            Assert.AreEqual(bookAFlight.flightTable.ElementAt(9).Text, test.booktotalPrice);
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

        public static void SelectByText(IWebElement element, String str)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(str);
        }

        
        public void Close()
        {
            
            driver.Quit();
        }
       
    }
}
