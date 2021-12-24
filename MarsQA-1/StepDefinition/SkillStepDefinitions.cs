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
    public class SkillStepDefinitions : Start
    {
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
        [Given(@"I click on the Skill tab")]
        public void GivenIClickOnTheSkillTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement skillTab = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Skills']")));
            skillTab.Click();
        }

        [Test, Order(3)]
        [Given(@"I click Add New button")]
        public void GivenIClickAddNewButton()
        {
            Driver.TurnOnWait();
            IWebElement AddnewButton = driver.FindElement(By.XPath("(//div[text()='Add New'])[2]"));
            AddnewButton.Click();
        }

        [Test, Order(4)]
        [Given(@"I enter skill text box")]
        public void GivenIEnterSkillTextBox()
        {
            Thread.Sleep(2000);
            IWebElement AddskillTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            Thread.Sleep(2000);
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "skill");
            AddskillTextbox.SendKeys(ExcelLibHelper.ReadData(2, "skill"));
        }

        [Test, Order(5)]
        [Given(@"I choose Intermediate in skill level")]
        public void GivenIChooseIntermediateInSkillLevel()
        {
            IWebElement SelectskillLevel = driver.FindElement(By.XPath("(//SELECT[@class='ui fluid dropdown'])"));
            SelectskillLevel.Click();

            var selectElement = new SelectElement(SelectskillLevel);
            selectElement.SelectByValue("Intermediate");
        }

        [Test, Order(6)]
        [When(@"I click on the Add button")]
        public void WhenIClickOnTheAddButton()
        {
            IWebElement addButn = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            addButn.Click();
        }

        [Test, Order(7)]
        [Then(@"I should see a pop up message C\# have been added to your skill")]
        public void ThenIShouldSeeAPopUpMessageCHaveBeenAddedToYourSkill()
        {
            IWebElement Skillcolumn = driver.FindElement(By.XPath("//*[@data-tab='second']/div/div[2]/div/table/tbody/tr[1]/td[1]"));
            Assert.AreEqual(Skillcolumn.Text, "C#");

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("./MarsQA-1/TestReports/Screenshots/Screenshot-C#.png", ScreenshotImageFormat.Png);
        }

        [Test, Order(8)]
        [Given(@"I click on Add New button in skill field")]
        public void GivenIClickOnAddNewButtonInSkillField()
        {
            Thread.Sleep(10000);
            Driver.TurnOnWait();
            IWebElement AddnewButton = driver.FindElement(By.XPath("(//div[text()='Add New'])[2]"));
            AddnewButton.Click();
        }

        [Test, Order(9)]
        [When(@"I enter second skill text box")]
        public void GivenIEnterSecondSkillTextBox()
        {
            Thread.Sleep(2000);
            IWebElement AddskillTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            Thread.Sleep(2000);
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "skill");
            AddskillTextbox.SendKeys(ExcelLibHelper.ReadData(3, "skill"));
        }

        [Test, Order(10)]
        [Then(@"I click the Add button")]
        public void WhenIClickTheAddButton()
        {
            IWebElement addButn = driver.FindElement(By.XPath("(//INPUT[@type='button'])"));
            addButn.Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("./MarsQA-1/TestReports/Screenshots/Screenshot-Python.png", ScreenshotImageFormat.Png);
        }

        
          

        
    }
}
