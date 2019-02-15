using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace PageObject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver web = new OpenQA.Selenium.Chrome.ChromeDriver();

            
            web.Url = "https://market.yandex.ru/catalog--mobilnye-telefony/54726/list?hid=91491&onstock=1&local-offers-first=0";

            //var phoneField = new PhonePage();
            //PageFactory.InitElements(web, phoneField);
            //
            int size;
            //size = phoneField.PhoneFields.Count;
            //for (int i = 0; i < size; i++)
            //{
            //    string name = phoneField.PhoneFields.ElementAt(i).Text;
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine(new String('\n',5));

            var sort = new Sort4Gb();
            PageFactory.InitElements(web, sort);
            
            size = sort.sort4Gb.Count;
            String[] phone4Gb = new String[size];
            
            for (int i = 0; i < size; i++)
            {
                //string name = sort.sort4Gb.ElementAt(i).Text;
                phone4Gb[i] = sort.sort4Gb.ElementAt(i).Text;
                //Console.WriteLine(phone4Gb[i]);
            }
            web.Quit();
            for (int i = 0; i < phone4Gb.Length; i++)
            {
                Console.WriteLine(phone4Gb[i]);
            }

            //for (int i = 0; i < size; i++)
            //{
            //    string name = sort.sort4Gb.ElementAt(i).Text;
            //    Console.WriteLine(name);
            //}

            
            Console.ReadLine();
        }
    }
}
