using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Activities.Expressions;
using System.Drawing.Imaging;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1
{
    [Binding]
    public class LanguageStepDefinitions : Start
    {
        //public object AddlanguageTextbox { get; private set; }
       [Test, Order(1)]
        [Given(@"Iam on my profile page")]
        public void GivenIamOnMyProfilePage()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();
        }

        
        [Test, Order(2)]

        [Given(@"I click AddNew butn in the language field")]
        public void GivenIClickAddNewButnInTheLanguageField()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            IWebElement AddnewButn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[text()='Add New'])[1]")));
            AddnewButn.Click();
        }

        

        [Test, Order(3)]
        [Given(@"I enter language in the language textbox")]
        public void GivenIEnterInTheLanguageTextbox()
        {
            IWebElement AddlanguageTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "language");
            AddlanguageTextbox.SendKeys(ExcelLibHelper.ReadData(2, "language"));
        }

        [Test, Order(4)]
        [Given(@"I select level from language level dropdown")]
        public void GivenISelectLevelFromLanguageLevelDropdown()
        {
            IWebElement SelectlanguageLevel = driver.FindElement(By.XPath("(//SELECT[@class='ui dropdown'])"));
            SelectlanguageLevel.Click();

            var selectElement = new SelectElement(SelectlanguageLevel);
            selectElement.SelectByValue("Basic");
        }

        

        [Test, Order(5)]
        [When(@"I click the Add butn")]
        public void WhenIClickTheAddButn()
        {
            IWebElement addButn= driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            addButn.Click();
        }

        
        
       [Test, Order(6)]
        [Then(@"I should see French added in the language textbox")]
        public void ThenIShouldSeeFrenchAddedInTheLanguageTextbox()
        {
 
            
            IWebElement Languagecolumn = driver.FindElement(By.XPath("//*[@data-tab='first']/div/div[2]/div/table/tbody/tr[1]/td[1]"));
            Assert.AreEqual(Languagecolumn.Text, "French");

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("./MarsQA-1/TestReports/Screenshots/Screenshot-French.png", ScreenshotImageFormat.Png);
        }

        [Test, Order(7)]
        [Given(@"I click AddNew butn to add second language in the language field")]
        public void GivenIClickAddNewButnToAddSecondLanguageInTheLanguageField()
        {
            Thread.Sleep(10000);
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement AddnewButn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[text()='Add New'])[1]")));
            AddnewButn.Click();
        }

        [Test, Order(8)]
        [Given(@"I enter second language in the language textbox")]
        public void GivenIEnterSecondLanguageInTheLanguageTextbox()
        {
            IWebElement AddlanguageTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "language");
            AddlanguageTextbox.SendKeys(ExcelLibHelper.ReadData(3, "language"));
        }

        [Test, Order(9)]
        [Then(@"I should see Please enter language and level")]
        public void ThenIShouldSeePleaseEnterLanguageAndLevel()
        {
            IWebElement addButn = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            addButn.Click();

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("./MarsQA-1/TestReports/Screenshots/Screenshot-English.png", ScreenshotImageFormat.Png);


        }

        [Test, Order(10)]
        public new void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();

            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();


        }


    }
}
        