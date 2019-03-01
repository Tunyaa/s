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

        public int type = 1; //0-1
        public int passengers = 1; //0-3 
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
    }
}
