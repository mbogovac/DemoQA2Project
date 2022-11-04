using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA2.Scenarios.PracticeForm
{
    public class PracticeFormInvalidData
    {
        public PracticeFormInvalidData()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
            NavigateTo.FromHomePageToFormsPage();

            FormsPage formsPage = new FormsPage();
            formsPage.PracticeForm.Click();
        }

        [Test]
        public void EmptyData()
        {
            FormsPage formsPage = new FormsPage();

            formsPage.FirstName.SendKeys(Config.InvalidData.Empty);
            formsPage.LastName.SendKeys(Config.InvalidData.Empty);
            formsPage.UserEmail.SendKeys(Config.InvalidData.Blank);
            formsPage.MobileNumber.SendKeys(Config.InvalidData.Empty);

            formsPage.MobileNumber.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            Assert.AreEqual("rgb(220, 53, 69)", formsPage.FirstName.GetCssValue("border-color"));
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.LastName.GetCssValue("border-color"));
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.UserEmail.GetCssValue("border-color"));
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.MobileNumber.GetCssValue("border-color"));
        }

        [Test]
        public void InvalidMobile()
        {
            FormsPage formsPage = new FormsPage();
            formsPage.MobileNumber.SendKeys(Config.InvalidData.Mobile);
            Assert.AreEqual(10, formsPage.MobileNumber.Text.Length);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
