using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nikonCanon.Web;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace nikonCanon
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest run = new RunTest();
            run.Run();
        }
    }
}
