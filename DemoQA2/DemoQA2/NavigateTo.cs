using DemoQA2.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA2
{
    public static class NavigateTo
    {
        public static void FromHomePageToAlertsPage()
        {
            HomePage homePage = new HomePage();
            homePage.AlertOption.Click();
        }

        public static void FromHomePageToElementsPage()
        {
            HomePage homePage = new HomePage();
            homePage.ElementsOption.Click();
        }

        public static void FromHomePageToFormsPage()
        {
            HomePage homePage = new HomePage();
            homePage.FormsOption.Click();
        }
    }
}
