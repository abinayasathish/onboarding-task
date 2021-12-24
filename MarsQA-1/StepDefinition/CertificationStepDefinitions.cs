using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class CertificationStepDefinitions : Start
    {
        [Test, Order(1)]
        [Given(@"Iam on my Profilepage")]
        public void GivenIamOnMyProfilepage()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();
        }

        [Test, Order(2)]
        [Given(@"I click on the Certification tab")]
        public void GivenIClickOnTheCertificationTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement certificateTab = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Certifications']")));
            certificateTab.Click();
        }

        [Test, Order(3)]
        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            Driver.TurnOnWait();
            IWebElement AddnewButton = driver.FindElement(By.XPath("(//div[text()='Add New'])[4]"));
            AddnewButton.Click();

        }

        [Test, Order(4)]
        [Given(@"I enter certification in certification or award text box")]
        public void GivenIEnterCertificationInCertificationOrAwardTextBox()
        {
            Thread.Sleep(2000);
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//input[@class='certification-award capitalize']"));
            
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "certificate");
            certificateTextbox.SendKeys(ExcelLibHelper.ReadData(2, "certificate"));
            

        }

        [Test, Order(5)]
        [Given(@"I enter certification from in text box")]
        public void GivenIEnterCertificationFromInTextBox()
        {
            IWebElement certificateFrom = driver.FindElement(By.XPath("//input[@class='received-from capitalize']"));
            
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "certificate");
            certificateFrom.SendKeys(ExcelLibHelper.ReadData(3, "certificate"));
        }

        [Test, Order(6)]
        [Given(@"I click the year dropdown list")]
        public void GivenIClickTheYearDropdownList()
        {
            Driver.TurnOnWait();
            IWebElement YearDdOption = Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            var selectElement = new SelectElement(YearDdOption);
            selectElement.SelectByValue("2021");
        }

        [Test, Order(7)]
        [When(@"I click Add button")]
        public void WhenIClickAddButton()
        {
            IWebElement Addbutn = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            Addbutn.Click();
        }
        

        [Test, Order(8)]
        [Then(@"I should see a pop up message certificate added to your Certification")]
        public void ThenIShouldSeeAPopUpMessageCertificateAddedToYourCertification()
        {
            IWebElement Certification = driver.FindElement(By.XPath("//*[@data-tab='fourth']/div/div[2]/div/table/tbody/tr[1]/td[1]"));
            Assert.AreEqual(Certification.Text, "Java");

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("./MarsQA-1/TestReports/Screenshots/Screenshot-Java.png", ScreenshotImageFormat.Png);
        }

        [Test, Order(9)]
        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButtonToAddSecondCertificate()
        {
            Thread.Sleep(10000);
            IWebElement AddnewButton = driver.FindElement(By.XPath("(//div[text()='Add New'])[4]"));
            AddnewButton.Click();

        }

        [Test, Order(10)]
        [Given(@"I click the year dropdown list")]
        public void GivenIClickTheYearDropdownListToAddNewCerfiticate()
        {
            Driver.TurnOnWait();
            IWebElement YearDdOption = Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            var selectElement = new SelectElement(YearDdOption);
            selectElement.SelectByValue("2019");
        }

        [Test, Order(11)]
        [Then(@"I should see Please enter certification name, certification from and certification year")]
        public void ThenIShouldSeePleaseEnterCertificationNameCertificationFromAndCertificationYear()
        {
            IWebElement Addbutn = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            Addbutn.Click();
            Thread.Sleep(1000);

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("./MarsQA-1/TestReports/Screenshots/Screenshot-2022.png", ScreenshotImageFormat.Png);

        }


    }
}