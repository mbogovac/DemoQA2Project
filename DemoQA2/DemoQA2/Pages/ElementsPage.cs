using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class ElementsPage
    {
        public ElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[1]")]
        public IWebElement TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement PermanentAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"userForm\"]/div[5]/div/button")]
        public IWebElement SubmitButton { get; set; }


        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement NameResult { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailResult { get; set; }
    }
}
