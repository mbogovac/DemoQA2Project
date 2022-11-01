using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class AlertsPage
    {
        public AlertsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[3]/div/ul/li[2]")]
        public IWebElement Alerts { get; set; }

        [FindsBy(How = How.Id, Using = "alertButton")]
        public IWebElement FirstAlertButton { get; set; }

        [FindsBy(How = How.Id, Using = "timerAlertButton")]
        public IWebElement TimerAlertButton { get; set; }

        [FindsBy(How = How.Id, Using = "confirmButton")]
        public IWebElement ConfirmAlertButton { get; set; }

        [FindsBy(How = How.Id, Using = "confirmResult")]
        public IWebElement ConfirmResult { get; set; }
    }
}
