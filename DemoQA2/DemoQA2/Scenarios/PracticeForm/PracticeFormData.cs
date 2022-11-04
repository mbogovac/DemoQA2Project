using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA2.Scenarios.PracticeForm
{
    public class PracticeFormData
    {
        public PracticeFormData()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
            NavigateTo.FromHomePageToFormsPage();

            FormsPage formsPage = new FormsPage();
            formsPage.PracticeForm.Click();
        }

        [Test]
        public void EnterAllData()
        {
            FormsPage formsPage = new FormsPage();

            formsPage.FirstName.SendKeys(Config.ValidData.FirstName);
            formsPage.LastName.SendKeys(Config.ValidData.LastName);
            formsPage.UserEmail.SendKeys(Config.ValidData.Email);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));

            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(formsPage.RadioBtnOther).Click().Perform();

            formsPage.MobileNumber.SendKeys(Config.ValidData.Mobile);

            formsPage.DateOfBirth.Click();
            SelectElement month = new SelectElement(formsPage.MonthSelect);
            month.SelectByText("April");
            SelectElement year = new SelectElement(formsPage.YearSelect);
            year.SelectByText("2019");
            formsPage.DaySelect.Click();

            formsPage.SubjectInput.SendKeys(Config.ValidData.Subject);

            for (int i = 0; i < 3; i++)
            {
                formsPage.SubjectInput.SendKeys(Keys.ArrowDown);
            }

            formsPage.SubjectInput.SendKeys(Keys.Enter);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(formsPage.MusicCheckbox));

            formsPage.MusicCheckbox.Click();
            formsPage.CurrentAddress.SendKeys(Config.ValidData.CurrentAddress);

            formsPage.StateInput.SendKeys(Config.ValidData.State);
            formsPage.StateInput.SendKeys(Keys.Enter);

            formsPage.CityInput.SendKeys(Config.ValidData.City);
            formsPage.CityInput.SendKeys(Keys.Enter);
            formsPage.CityInput.SendKeys(Keys.Enter);

            Assert.AreEqual(Config.Messages.ThankYouMessage, formsPage.ThanksMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
