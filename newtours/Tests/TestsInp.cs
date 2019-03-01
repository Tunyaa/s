using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using newtours.Inputs;
using newtours.Web;
using OpenQA.Selenium;

namespace newtours.Tests
{
    class TestsInp
    {
        
        public String findTitle = "Find a Flight: Mercury Tours:";

        public String selectTitle = "Select a Flight: Mercury Tours";
        public String selectDep = "Paris to Seattle";
        public String selectDepDate = "11/20/2019";   //11/20/2015
        public String priceDep = "281";
        
        public String selectRet = "Seattle to Paris";
        public String selectRetDate = "12/19/2019";  //"12/19/2015";
        public String priceRet = "273";
        

        public String bookTitle = "Book a Flight: Mercury Tours";

        public String bookDep = "Paris to Seattle";
        public String bookDepDate = "11/20/2019";    //"11/20/2015"
        public String bookDepFlight = "Unified Airlines 363";
        public String bookDepClass = "Business";
        public String bookDepPrice = "281";

        public String bookRet = "Seattle to Paris";
        public String bookRetDate = "12/19/2019";        // "12/19/2015"
        public String bookRetFlight = "Blue Skies Airlines 631";
        public String bookRetClass = "Business";
        public String bookRetPrice = "273";

        public String bookPassengers = "2";
        public String bookTaxes = "$91";
        public String booktotalPrice = "$1199";
        
        public int TotalPrice(int priceDepart, int priceReturn, String passengers, String taxes)
        {
            int pas = Int32.Parse(passengers);
            int tax = Int32.Parse(taxes);
            int totalPrice = (priceDepart + priceReturn) * 2 + 91;
            return totalPrice;
        }
    }
}
