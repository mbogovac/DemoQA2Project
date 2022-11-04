using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2
{
    public static class Config
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Driver.BaseUrl);
            Driver.driver.Manage().Window.Maximize();
        }

        public static string Name = "petar";

        public static class ValidData
        {
            public static string FullName = "Petar Petrovic";
            public static string Email = "p@gmail.com";
            public static string CurrentAddress = "example1";
            public static string PermanentAddress = "example2";

            public static string FirstName = "Petar";
            public static string LastName = "Petrovic";
            public static string Mobile = "1110002222";
            public static string Subject = "E";
            public static string State = "NCR";
            public static string City = "Delhi";
        }

        public static class InvalidData
        {
            public static string Email = "m @gmail.com";
            public static string Mobile = "1110002222333";
            public static string Empty = "";
            public static string Blank = " ";
        }

        public static class Messages
        {
            public static string ThankYouMessage = "Thanks for submitting the form";
        }

    }
}
