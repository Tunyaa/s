using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtours.Inputs
{
    class UInputs
    {

        public String url = "http://newtours.demoaut.com/";
        public String userName = "tutorial";
        public String password = "tutorial";

        public String tp = "oneway";
        public int type = 1; //0-1
        public String passengers = "2";  
        public String departFrom = "Paris";
        public String OnMonth = "November";
        public String OnDay = "20";
        public String arrivIn = "Seattle";
        public String returnMonth = "December";
        public String returnDay = "19";
        public int serviceClass = 1; //0-2
        public String airline = "Pangea Airlines";

        public int flightOut = 3; //0-3
        public int flightIn = 1; //0-3

        public String firstNamePas1 = "Ivan";
        public String lastNamePas1 = "Ivanov";
        public String mealPas1 = "Hindu";
        public String firstNamePas2 = "Irina";
        public String lastNamePas2 = "Ivanova";
        public String mealPas2 = "Bland";
        public String cardType = "Visa";
        public String cardNumber = "5479540454132487";
        public String cardExM = "05";
        public String cardExY = "2009";
        public String cardFirstName = "Ivan";
        public String cardMiddleName = "Ivanovich";
        public String cardLastName = "Ivanov";

        public String bilAddress = "1085 Borregas Ave.";
        public String bilCity = "Albuquerque";
        public String bilState = "New Mexico";
        public String bilPostCode = "94089";
        public String bilCountry = "UNITED STATES";

        public String deliAddress = "Same as Billing Address";
        public String deliCity = "Boston";
        public String deliState = "Massachusetts";
        public String deliPostCode = "91089";
        public String deliCountry = "UNITED STATES";

        public int Price;
    }
}
