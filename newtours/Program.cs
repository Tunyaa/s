using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using newtours.Web;

namespace newtours
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Body run = new Body();
            run.Run();
            
        }
    }
}
