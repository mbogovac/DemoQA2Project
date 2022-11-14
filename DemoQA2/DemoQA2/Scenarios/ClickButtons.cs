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

namespace DemoQA2.Scenarios
{
    public class ClickButtons
    {
        public ClickButtons()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {

            Config.InitializeDriver();
            NavigateTo.FromHomePageToElementsPage();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]")));

            NavigateTo.FromElementsPageToButtonsPage();
        }

        [Test]
        public void DoubleClick()
        {
            ButtonsPage buttonsPage = new ButtonsPage();

            Actions actions = new Actions(Driver.driver);
            actions.DoubleClick(buttonsPage.DoubleClickButton).Perform();

            Assert.AreEqual(Config.Messages.DoubleClickMessage, buttonsPage.DoubleClickMessage.Text);
        }

        [Test]
        public void RightClick()
        {
            ButtonsPage buttonsPage = new ButtonsPage();

            Actions actions = new Actions(Driver.driver);
            actions.ContextClick(buttonsPage.RightClickButton).Perform();

            Assert.AreEqual(Config.Messages.RightClickMessage, buttonsPage.RightClickMessage.Text);
        }

        [Test]
        public void DynamicClick()
        {
            ButtonsPage buttonsPage = new ButtonsPage();

            buttonsPage.ClickButton.Click();
            Assert.AreEqual(Config.Messages.DynamicClickMessage, buttonsPage.DynamicClickMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
