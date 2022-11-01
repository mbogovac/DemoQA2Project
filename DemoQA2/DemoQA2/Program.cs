using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA2
{
    class Program
    {
        static void Main()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
        }

        [Test]
        public void AcceptFirstAlert()
        {
            NavigateTo.FromHomePageToAlertsPage();
            AlertsPage alertsPage = new AlertsPage();
            alertsPage.Alerts.Click();
            alertsPage.FirstAlertButton.Click();

            var text = Driver.driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[1]/div"));

            Assert.AreEqual("Alerts", text.Text);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
