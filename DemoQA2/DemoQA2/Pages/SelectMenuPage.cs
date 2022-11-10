using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class SelectMenuPage
    {
        public SelectMenuPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "react-select-2-input")]
        public IWebElement SelectValueDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "react-select-3-input")]
        public IWebElement SelectOneDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "oldSelectMenu")]
        public IWebElement OldStyleDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "react-select-4-input")]
        public IWebElement MultiSelectDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "cars")]
        public IWebElement StandardMultiSelect { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"withOptGroup\"]/div/div[1]/div[1]")]
        public IWebElement TextInValueDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"selectOne\"]/div/div[1]/div[1]")]
        public IWebElement TextInSelectOneDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"selectMenuContainer\"]/div[7]/div/div/div/div[1]/div[1]/div/div[1]")]
        public IWebElement FirstOptInMultiSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"selectMenuContainer\"]/div[7]/div/div/div/div[1]/div[2]/div/div[1]")]
        public IWebElement SecondOptInMultiSelect { get; set; }


    }
}
