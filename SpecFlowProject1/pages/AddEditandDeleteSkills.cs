using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecFlowProject1.utilities;
using static System.Collections.Specialized.BitVector32;

namespace SpecFlowProject1.pages
{
    public class AddEditandDeleteSkills
    {
        public void navigateToSkill(IWebDriver webdriver)
        {
            IWebElement navigate = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            navigate.Click();
        }
        public void AddSkills(IWebDriver webdriver)
        {
            webdriver.Manage().Window.Maximize();

            Console.WriteLine("Adding new Skill");
            IWebElement addnew = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnew.Click();
        }
        public void addSkillandLevel(IWebDriver webdriver, String code)
        {
            IWebElement enter_Skill = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            enter_Skill.SendKeys(code);
            IWebElement skill_level = webdriver.FindElement(By.Name("level"));
            skill_level.Click();
            WaitUtilis.WaitToBeVisible(webdriver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 5);
            //if( Level=="")
           // IWebElement optionBeginner= webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
           // optionBeginner.Click();
            IWebElement optionIntermediate = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            optionIntermediate.Click();
            //IWebElement optionExpert = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            // optionExpert.Click();
            IWebElement add_Skill = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            add_Skill.Click();

        }
        public void deleteSkill(IWebDriver webdriver)
        {
            IWebElement deletebutton = webdriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deletebutton.Click();
            IWebElement verifydelete = webdriver.FindElement(By.XPath("/html/body/div[1]/div"));
            if (verifydelete.Text == "Hindi has been deleted from your languages")
            {
                Console.WriteLine("language has been deleted");

            }



        }
        public void editSkill(IWebDriver webdriver)
        {
            Thread.Sleep(3000);
            Console.WriteLine("i am before editing");
            IWebElement editbutton = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editbutton.Click();
            IWebElement enter_skill= webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            enter_skill.Clear();
            Console.WriteLine("i am adding Linux");
            enter_skill.SendKeys("Linux");
            Console.WriteLine("i am before Level");
            IWebElement skill_level = webdriver.FindElement(By.Name("level"));
            skill_level.Click();
            WaitUtilis.WaitToBeVisible(webdriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select", 10);
            IWebElement option_expert = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            option_expert.Click();
            Thread.Sleep(1000);
            Console.WriteLine("i am after clicking basic");
            
            IWebElement updatebutton = webdriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatebutton.Click();





        }
    }
}
