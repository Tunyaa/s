using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Buttons
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver web = new OpenQA.Selenium.Chrome.ChromeDriver();
            web.Manage().Window.Maximize();
            
            web.Navigate().GoToUrl("https://market.yandex.ru/catalog--mototsikly/54885/list?hid=90498&onstock=1&local-offers-first=0");

            string[] chkOpt = new string[6] { "Honda", "BMW", "YAMAHA", "жидкостное", "6", "Гарантия производителя" };
            IList<IWebElement> chkBtn_Prod = web.FindElements(By.ClassName("NVoaOvqe58"));
            int iSize = chkBtn_Prod.Count();

            for (int i = 0; i < iSize; i++)
            {
                string value = chkBtn_Prod.ElementAt(i).Text;

                for (int j = 0; j < chkOpt.Length; j++)
                {
                    if (value.Equals(chkOpt[j]))
                    {
                        chkBtn_Prod.ElementAt(i).Click();
                    }
                }
            }
            Task.Delay(3000).Wait();
            //web.Quit();
            Console.ReadLine();
        }
    }
}
