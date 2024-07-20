using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.utilities;
using static System.Collections.Specialized.BitVector32;

namespace SpecFlowProject1.pages
{
    public class AddnEditandDeletelanguages
    {
        public void AddLanguages(IWebDriver webdriver)
        {
            webdriver.Manage().Window.Maximize();

            Console.WriteLine("Adding new language");
            IWebElement addnew = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnew.Click();
        }
        public void addLanguageandProficiency(IWebDriver webdriver, String code)
        {
            IWebElement enter_language = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            enter_language.SendKeys(code);
            IWebElement proficiency_level = webdriver.FindElement(By.Name("level"));
            proficiency_level.Click();
            WaitUtilis.WaitToBeVisible(webdriver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 5);
            IWebElement option_basic = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            option_basic.Click();
            IWebElement add_language = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add_language.Click();

        }
        public void Verifylanguageadded(IWebDriver webdriver)
        {
            IWebElement languageTextbox = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement proficiencySelector = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            if (languageTextbox.Text == "tamil" && proficiencySelector.Text == "Basic")
            {
                Console.WriteLine("New language added");
                

            }
            else
            {
                Console.WriteLine("New language not added");
            }

        


        }
        public void deleteLanguage(IWebDriver webdriver)
        {
            IWebElement deletebutton = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deletebutton.Click();
            IWebElement verifydelete = webdriver.FindElement(By.XPath("/html/body/div[1]/div"));
            if(verifydelete.Text== "Hindi has been deleted from your languages")
            {
                Console.WriteLine("language has been deleted");

            }



        }
        public void editLanguages(IWebDriver webdriver)
        {
            IWebElement editbutton = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editbutton.Click();
            IWebElement enter_language = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            enter_language.Clear();
            Console.WriteLine("i am adding french");
            enter_language.SendKeys("French");
            Console.WriteLine("i am before proficieny");
            IWebElement proficiency_level = webdriver.FindElement(By.Name("level"));
            proficiency_level.Click();
            WaitUtilis.WaitToBeVisible(webdriver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select", 10);
            IWebElement option_basic = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            option_basic.Click();
            Console.WriteLine("i am after clicking basic");
            Thread.Sleep(1000);
            IWebElement updatebutton = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatebutton.Click();





        }
        public void verifyLanguageUpdated(IWebDriver webdriver)
        {
            IWebElement verifyupdate = webdriver.FindElement(By.XPath("/html/body/div[1]/div"));
            if(verifyupdate.Text == "French has been updated to your languages")
            {
                Console.WriteLine("language updated");
            }



        }



    }
}
