using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

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
            public static string MobileMoreThan10 = "1110002222333";
            public static string Empty = "";
            public static string Blank = " ";
            public static string MobileLessThan10 = "111";
        }

        public static class Messages
        {
            public static string ThankYouMessage = "Thanks for submitting the form";
            public static string DoubleClickMessage = "You have done a double click";
            public static string RightClickMessage = "You have done a right click";
            public static string DynamicClickMessage = "You have done a dynamic click";
        }

        }
    }
