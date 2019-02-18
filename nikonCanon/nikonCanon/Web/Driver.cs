using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using nikonCanon.Page;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace nikonCanon.Web
{
    class Driver 
    {
        
        public IWebDriver web;
        [SetUp]
        public void Web()
        {
            web = new OpenQA.Selenium.Chrome.ChromeDriver();
            web.Url = "http://foto-i-video.ru";
            
        }
        [Test]
        public void Click()
        {
            var mainPage = new MainPage();
            PageFactory.InitElements(web, mainPage);
            mainPage.AllCams.Click();
        }
        
        public void Canon()
        {
            var canonPage = new CanonPage();
            PageFactory.InitElements(web, canonPage);
            int iSize = canonPage.CanonCams.Count();
            for (int i = 0; i < iSize; i++)
            {
                string name = canonPage.CanonCams.ElementAt(i).Text;
                Console.WriteLine(name);
            }
        }

        public void Nikon()
        {
            var nikonPage = new NikonPage();
            PageFactory.InitElements(web, nikonPage);
            int iSize = nikonPage.nikonCams.Count;
            for (int i = 0; i < iSize; i++)
            {
                string name = nikonPage.nikonCams.ElementAt(i).Text;
                Console.WriteLine(name);
            }
        }
        [TearDown]
        public void Quit()
        {
            web.Quit();
        }
    }
}
