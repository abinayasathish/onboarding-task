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
    internal class Skill : Start
    {
        [Test]
        public void Skilladd()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();



            //identify Skilltab and click
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement skillTab = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Skills']")));
            skillTab.Click();


            //identify AddNew button and click
            Driver.TurnOnWait();
            IWebElement AddnewButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[text()='Add New'])[2]")));
            AddnewButton.Click();



            //identify  Addskill textbox and enter skill
            Thread.Sleep(2000);
            IWebElement AddskillTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            Thread.Sleep(2000);
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "skill");
            AddskillTextbox.SendKeys(ExcelLibHelper.ReadData(2, "skill"));


            //identify Skilllevel dropdown list and select skill level
            IWebElement SelectskillLevel = driver.FindElement(By.XPath("(//SELECT[@class='ui fluid dropdown'])"));
            SelectskillLevel.Click();

            var selectElement = new SelectElement(SelectskillLevel);
            selectElement.SelectByValue("Intermediate");

            //identify Addbutn and click
            IWebElement addButn = driver.FindElement(By.XPath("(//input[@value='Add'])[2]"));
            addButn.Click();
        }

            
    }
}
