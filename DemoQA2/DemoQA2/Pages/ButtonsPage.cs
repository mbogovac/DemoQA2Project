using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class ButtonsPage
    {
        public ButtonsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "doubleClickBtn")]
        public IWebElement DoubleClickButton { get; set; }

        [FindsBy(How = How.Id, Using = "rightClickBtn")]
        public IWebElement RightClickButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/div[3]/button")]
        public IWebElement ClickButton { get; set; }

        [FindsBy(How = How.Id, Using = "doubleClickMessage")]
        public IWebElement DoubleClickMessage { get; set; }

        [FindsBy(How = How.Id, Using = "rightClickMessage")]
        public IWebElement RightClickMessage { get; set; }

        [FindsBy(How = How.Id, Using = "dynamicClickMessage")]
        public IWebElement DynamicClickMessage { get; set; }
    }
}
