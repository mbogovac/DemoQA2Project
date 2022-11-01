using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2
{
    public static class Driver
    {
        public static string BaseUrl = "https://demoqa.com/";

        public static IWebDriver driver { get; set; }
    }
}
