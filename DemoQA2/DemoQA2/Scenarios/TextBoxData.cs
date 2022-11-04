using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoQA2.Scenarios
{
    public class TextBoxData
    {
        public TextBoxData()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
            NavigateTo.FromHomePageToElementsPage();

            ElementsPage elementsPage = new ElementsPage();
            elementsPage.TextBox.Click();
        }

        [Test]
        public void EnterAllData()
        {
            ElementsPage elementsPage = new ElementsPage();

            elementsPage.Username.SendKeys(Config.ValidData.FullName);
            elementsPage.Email.SendKeys(Config.ValidData.Email);
            elementsPage.CurrentAddress.SendKeys(Config.ValidData.CurrentAddress);
            elementsPage.PermanentAddress.SendKeys(Config.ValidData.PermanentAddress);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(elementsPage.SubmitButton));

            elementsPage.SubmitButton.Click();

            Assert.AreEqual("Name:"+Config.ValidData.FullName, elementsPage.NameResult.Text);
            Assert.AreEqual("Email:"+Config.ValidData.Email, elementsPage.EmailResult.Text);
        }

        [Test]
        public void EnterInvalidEmail()
        {
            ElementsPage elementsPage = new ElementsPage();

            elementsPage.Username.Clear();
            elementsPage.Email.Clear();

            elementsPage.Username.SendKeys(Config.ValidData.FullName);
            elementsPage.Email.SendKeys(Config.InvalidData.Email);
            elementsPage.SubmitButton.Click();

            Assert.AreEqual("mr-sm-2 field-error form-control", elementsPage.Email.GetAttribute("class"));
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
