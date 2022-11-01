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
    public class HandlingAlerts
    {
        IAlert alert;
        public HandlingAlerts()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
            NavigateTo.FromHomePageToAlertsPage();
            AlertsPage alertsPage = new AlertsPage();
            alertsPage.Alerts.Click();
        }

        [Test]
        public void AcceptFirstAlert()
        {
            AlertsPage alertsPage = new AlertsPage();
            alertsPage.FirstAlertButton.Click();

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual("You clicked a button", alert.Text);

            alert.Accept();
        }

        [Test]
        public void AcceptTimerAlert()
        {
            AlertsPage alertsPage = new AlertsPage();
            alertsPage.TimerAlertButton.Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            var alertPresent = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual("This alert appeared after 5 seconds", alert.Text);

            alert.Accept();
        }

        [Test]
        public void AcceptThirdAlert()
        {
            AlertsPage alertsPage = new AlertsPage();
            alertsPage.ConfirmAlertButton.Click();

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual("Do you confirm action?", alert.Text);

            alert.Accept();
            Assert.AreEqual("You selected Ok", alertsPage.ConfirmResult.Text);
        }

        [Test]
        public void DismissThirdAlert()
        {
            AlertsPage alertsPage = new AlertsPage();
            alertsPage.ConfirmAlertButton.Click();

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual("Do you confirm action?", alert.Text);

            alert.Dismiss();
            Assert.AreEqual("You selected Cancel", alertsPage.ConfirmResult.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
