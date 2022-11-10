using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA2.Scenarios
{
    public class SelectMenuDropDowns
    {
        public SelectMenuDropDowns()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
            NavigateTo.FromHomePageToWidgetPage();

            WidgetsPage widgetsPage = new WidgetsPage();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", widgetsPage.SelectMenu);
            widgetsPage.SelectMenu.Click();
        }

        [Test]
        public void OldStyleDD()
        { 
            SelectMenuPage selectMenuPage = new SelectMenuPage();
            selectMenuPage.OldStyleDropDown.Click();
            SelectElement color = new SelectElement(selectMenuPage.OldStyleDropDown);
            color.SelectByText("Yellow");

            Assert.AreEqual("3", selectMenuPage.OldStyleDropDown.GetAttribute("value"));
        }

        [Test]
        public void SelectValueDD()
        {
            SelectMenuPage selectMenuPage = new SelectMenuPage();

            selectMenuPage.SelectValueDropDown.SendKeys("g");
            selectMenuPage.SelectValueDropDown.SendKeys(Keys.ArrowDown);
            selectMenuPage.SelectValueDropDown.SendKeys(Keys.ArrowDown);
            selectMenuPage.SelectValueDropDown.SendKeys(Keys.Enter);

            Assert.AreEqual("Group 2, option 1", selectMenuPage.TextInValueDropDown.Text);
        }

        [Test]
        public void SelectOneDD()
        {
            SelectMenuPage selectMenuPage = new SelectMenuPage();
            selectMenuPage.SelectOneDropDown.SendKeys("d");
            selectMenuPage.SelectOneDropDown.SendKeys(Keys.ArrowDown);
            selectMenuPage.SelectOneDropDown.SendKeys(Keys.Enter);

            Assert.AreEqual("Dr.", selectMenuPage.TextInSelectOneDropDown.Text);
        }

        [Test]
        public void StandardMultiSelectDD()
        {
            SelectMenuPage selectMenuPage = new SelectMenuPage();
            SelectElement cars = new SelectElement(selectMenuPage.StandardMultiSelect);
            cars.SelectByText("Volvo");
            cars.SelectByText("Opel");
        }

        [Test]
        public void MultiSelectDD()
        {
            SelectMenuPage selectMenuPage = new SelectMenuPage();
            selectMenuPage.MultiSelectDropDown.SendKeys("b");
            selectMenuPage.MultiSelectDropDown.SendKeys(Keys.Enter);
            selectMenuPage.MultiSelectDropDown.SendKeys("g");
            selectMenuPage.MultiSelectDropDown.SendKeys(Keys.Enter);

            Assert.AreEqual("Blue", selectMenuPage.FirstOptInMultiSelect.Text);
            Assert.AreEqual("Green", selectMenuPage.SecondOptInMultiSelect.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
