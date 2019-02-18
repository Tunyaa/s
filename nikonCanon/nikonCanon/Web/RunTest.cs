using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nikonCanon.Page;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace nikonCanon.Web
{
    class RunTest
    {
        
        public void Run()
        {
            
            Driver web = new Driver();
            web.Web();
            web.Click();
            Console.WriteLine("\n" + new string('_',30) + "CANON" + new string('_', 30));
            web.Canon();
            Console.WriteLine("\n" + new string('_', 30) + "18-55" + new string('_', 30));
            web.Nikon();
            web.Quit();
            Console.ReadLine();
            
        }
        
    }
}
