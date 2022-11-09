using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div/div[3]/div/div[1]")]
        public IWebElement AlertOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div/div[1]/div/div[1]")]
        public IWebElement ElementsOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div/div[2]/div/div[1]")]
        public IWebElement FormsOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div/div[4]/div/div[1]")]
        public IWebElement WidgetOption { get; set; }
    }
}
