using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class Language : Start
    {
        [Test]
        public void Languageadd()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();


            //identify AddNew button and click
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement AddnewButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[text()='Add New'])[1]")));
            AddnewButton.Click();

            //identify AddLanguage textbox and enter language
            IWebElement AddlanguageTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Credentials");
            AddlanguageTextbox.SendKeys(ExcelLibHelper.ReadData(2, "language"));


            Driver.TurnOnWait();

            //Select language level from dropdown
            IWebElement ChooselanguageLevel = driver.FindElement(By.XPath("(//SELECT[@class='ui dropdown'])"));
            ChooselanguageLevel.Click();

            var selectElement = new SelectElement(ChooselanguageLevel);
            selectElement.SelectByValue("Basic");

            //identify Add button and click
            IWebElement addButton = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            addButton.Click();

            Thread.Sleep(5000);

            //identify AddNew button and click
            IWebElement AddnewButton1 = driver.FindElement(By.XPath("(//div[text()='Add New'])[1]"));
            AddnewButton1.Click();

            Driver.TurnOnWait();

            //identify AddLanguage textbox and enter language
            IWebElement AddlanguageTextbox1 = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            AddlanguageTextbox1.SendKeys("French");

            //identify Add button and click
            IWebElement addButton1 = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            addButton1.Click();


            //Adding Assertions
            //Driver.TurnOnWait();
            //Assert.That(AddlanguageTextbox.Text == "English", "English has been added to your language");
            //Assert.That(AddlanguageTextbox.Text == "French", "Please enter language and level");

        }
    }
}