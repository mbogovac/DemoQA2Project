using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
        public void InvalidData()
        {
            FormsPage formsPage = new FormsPage();

            formsPage.FirstName.SendKeys(Config.InvalidData.Empty);
            formsPage.LastName.SendKeys(Config.InvalidData.Empty);
            formsPage.UserEmail.SendKeys(Config.InvalidData.Empty);
            formsPage.MobileNumber.SendKeys(Config.InvalidData.Empty);

            Assert.AreEqual("rgb(206, 212, 218)", formsPage.FirstName.GetCssValue("border-color"));
        }

        [Test]
        public void InvalidMobile()
        {
            FormsPage formsPage = new FormsPage();
            formsPage.MobileNumber.SendKeys(Config.InvalidData.Mobile);
            Thread.Sleep(3000);
           
            Assert.AreEqual(10, formsPage.MobileNumber.Text.Length);
            Thread.Sleep(3000);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
