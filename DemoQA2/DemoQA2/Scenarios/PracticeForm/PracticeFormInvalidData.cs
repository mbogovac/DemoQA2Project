using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

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

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));

            //IWebElement element = Config.WaitUntilAttributeValueEquals(formsPage.FirstName, "border-color", "");
            Thread.Sleep(2000);
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.FirstName.GetCssValue("border-color"));
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.LastName.GetCssValue("border-color"));
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.UserEmail.GetCssValue("border-color"));
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.MobileNumber.GetCssValue("border-color"));
        }

        [Test]
        public void MobileMoreThan10()
        {
            FormsPage formsPage = new FormsPage();
            formsPage.MobileNumber.SendKeys(Config.InvalidData.MobileMoreThan10);
            formsPage.MobileNumber.SendKeys(Keys.Enter);

            Assert.AreEqual(10, formsPage.MobileNumber.Text.Length);
        }

        [Test]
        public void MobileLessThan10()
        {
            FormsPage formsPage = new FormsPage();
            formsPage.MobileNumber.SendKeys(Config.InvalidData.MobileLessThan10);
            formsPage.MobileNumber.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Assert.AreEqual("rgb(220, 53, 69)", formsPage.MobileNumber.GetCssValue("border-color"));
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
    
}


