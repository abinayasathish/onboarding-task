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
    internal class Certification : Start
    {
        [Test]
        public void Certificationadd()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();

            

            //identify certificatetab and click
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement certificateTab = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Certifications']")));
            certificateTab.Click();


            //identify AddNew button and click
            Driver.TurnOnWait();
            IWebElement AddnewButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[text()='Add New'])[4]")));
            AddnewButton.Click();

            

            //identify Certificate or award textbox and enter certificate
            Thread.Sleep(2000);
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//input[@class='certification-award capitalize']"));
            Thread.Sleep(2000);
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "certificate");
            certificateTextbox.SendKeys(ExcelLibHelper.ReadData(2, "certificate"));

            
            //identify Certificate From textbox and enter certificatefrom
            IWebElement certificateFrom = driver.FindElement(By.XPath("//input[@class='received-from capitalize']"));
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "certificate");
            certificateFrom.SendKeys(ExcelLibHelper.ReadData(3, "certificate"));

            //Select year from the dropdown list
            Driver.TurnOnWait();
            IWebElement YearDdOption = Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            var selectElement = new SelectElement(YearDdOption);
            selectElement.SelectByValue("2021");

           //identify Addbutn and click
            IWebElement Addbutn = driver.FindElement(By.XPath("//input[@class='ui teal button ']"));
            Addbutn.Click();

            // Adding Assertions
           // Driver.TurnOnWait();
           // Assert.That(Certificatetextbox.Text == "Industry Connect Test Analyst", "Created certificate name hasn't found hence test case failed");
           // Assert.That(CreateCertifiedFromInputBox.Text == "Industry Connect", "Created certified from name hasn't been found hence test case is failed");


        }

    }
}

