using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class WidgetsPage
    {
        public WidgetsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[4]/span/div")]
        public IWebElement MenuWrapper { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Menu']")]
        public IWebElement Menu { get; set; }


        [FindsBy(How = How.LinkText, Using = "Main Item 2")]
        public IWebElement MainItem2 { get; set; }

        [FindsBy(How = How.LinkText, Using = "SUB SUB LIST »")]
        public IWebElement SubSubList { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sub Sub Item 1")]
        public IWebElement SubSubItem1{ get; set; }

    }
}
