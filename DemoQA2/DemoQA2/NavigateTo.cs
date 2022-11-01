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
            AlertsPage alertsPage = new AlertsPage();

            homePage.AlertOption.Click();
            Thread.Sleep(2000);

        }
    }
}
