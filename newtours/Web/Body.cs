using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace newtours.Web
{
    class Body
    {
        [Test]
        public void Run()
        {
            Driver driver = new Driver();
            driver.Chrome();
            driver.ChromeUrl();
            
            driver.Login();
            
           driver.FlightFinder();
            
            driver.FlightSelect();
            
            driver.BookAFlight();
            
            driver.Close();
        }
    }
}
