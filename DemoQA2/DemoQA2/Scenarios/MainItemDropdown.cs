using DemoQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA2.Scenarios
{
    public class MainItemDropdown
    {
        public MainItemDropdown()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
            NavigateTo.FromHomePageToWidgetPage();
            
        }

        [Test]
        public void HoverDropDown()
        {
            WidgetsPage widgetsPage = new WidgetsPage();

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", widgetsPage.Menu);
            widgetsPage.Menu.Click();

            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(widgetsPage.MainItem2).Perform();
            actions.MoveToElement(widgetsPage.SubSubList).Perform();

            Assert.IsTrue(widgetsPage.SubSubItem1.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
