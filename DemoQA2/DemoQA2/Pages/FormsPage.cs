using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA2.Pages
{
    public class FormsPage
    {
        public FormsPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li")]
        public IWebElement PracticeForm { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement UserEmail { get; set; }

        [FindsBy(How = How.Id, Using = "gender-radio-1")]
        public IWebElement RadioBtnMale { get; set; }

        [FindsBy(How = How.Id, Using = "gender-radio-2")]
        public IWebElement RadioBtnFemale { get; set; }

        [FindsBy(How = How.Id, Using = "gender-radio-3")]
        public IWebElement RadioBtnOther { get; set; }

        [FindsBy(How = How.Id, Using = "userNumber")]
        public IWebElement MobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "dateOfBirthInput")]
        public IWebElement DateOfBirth { get; set; }

        [FindsBy(How = How.ClassName, Using = "react-datepicker__month-select")]
        public IWebElement MonthSelect { get; set; }

        [FindsBy(How = How.ClassName, Using = "react-datepicker__year-select")]
        public IWebElement YearSelect { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".react-datepicker__day.react-datepicker__day--017")]
        public IWebElement DaySelect { get; set; }

        [FindsBy(How = How.Id, Using = "subjectsInput")]
        public IWebElement SubjectInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class=\"subjects-auto-complete__menu\"]/select")]
        public IWebElement SubjectsDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for=\"hobbies-checkbox-3\"]")]
        public IWebElement SportsCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for=\"hobbies-checkbox-3\"]")]
        public IWebElement ReadingCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for=\"hobbies-checkbox-3\"]")]
        public IWebElement MusicCheckbox { get; set; }

        [FindsBy(How = How.Id, Using = "uploadPicture")]
        public IWebElement ChooseFile { get; set; }

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "react-select-3-input")]
        public IWebElement StateInput{ get; set; }

        [FindsBy(How = How.Id, Using = "react-select-4-input")]
        public IWebElement CityInput { get; set; }

        [FindsBy(How = How.Id, Using = "example-modal-sizes-title-lg")]
        public IWebElement ThanksMessage { get; set; }
    }
}
