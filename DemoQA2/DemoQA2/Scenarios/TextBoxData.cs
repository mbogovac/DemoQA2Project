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
            NavigateTo.FromElementsPageToTextBoxPage();
        }

        [Test]
        public void EnterAllData()
        {
            TextBoxPage textBoxPage = new TextBoxPage();

            textBoxPage.Username.SendKeys(Config.ValidData.FullName);
            textBoxPage.Email.SendKeys(Config.ValidData.Email);
            textBoxPage.CurrentAddress.SendKeys(Config.ValidData.CurrentAddress);
            textBoxPage.PermanentAddress.SendKeys(Config.ValidData.PermanentAddress);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(textBoxPage.SubmitButton));

            textBoxPage.SubmitButton.Click();

            Assert.AreEqual("Name:"+Config.ValidData.FullName, textBoxPage.NameResult.Text);
            Assert.AreEqual("Email:"+Config.ValidData.Email, textBoxPage.EmailResult.Text);
        }

        [Test]
        public void EnterInvalidEmail()
        {
            TextBoxPage textBoxPage = new TextBoxPage();

            textBoxPage.Username.Clear();
            textBoxPage.Email.Clear();

            textBoxPage.Username.SendKeys(Config.ValidData.FullName);
            textBoxPage.Email.SendKeys(Config.InvalidData.Email);
            textBoxPage.SubmitButton.Click();

            Assert.AreEqual("mr-sm-2 field-error form-control", textBoxPage.Email.GetAttribute("class"));
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
