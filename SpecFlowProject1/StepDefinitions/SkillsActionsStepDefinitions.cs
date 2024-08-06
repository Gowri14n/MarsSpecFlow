using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using SpecFlowProject1.pages;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class SkillsActionsStepDefinitions
    {
        LoginMars login = new LoginMars();
        IWebDriver webdriver = new EdgeDriver();
        AddEditandDeleteSkills actions = new AddEditandDeleteSkills();
        [Given(@"user logins to MarsprojectSkills")]
        public void GivenUserLoginsToMarsprojectSkills()
        {
            login.LoginActions(webdriver);

        }
        [Then(@"user Navigates to Skill Module")]
        public void ThenUserNavigatesToSkillModule()
        {
            actions.navigateToSkill(webdriver);
            
        }

        [When(@"user clicks on Add new button under Skills")]
        public void WhenUserClicksOnAddNewButtonUnderSkills()
        {
            actions.AddSkills(webdriver);
        }

        [When(@"user enters Skills and level '([^']*)'")]
        public void WhenUserEntersSkillsAndLevel(string skills)
        {
            actions.addSkillandLevel(webdriver, skills);
            
        }

        [When(@"user clicks on Skillsaddbutton")]
        public void WhenUserClicksOnSkillsaddbutton()
        {
            
        }

        [Then(@"skill language is added")]
        public void ThenSkillLanguageIsAdded()
        {
            Thread.Sleep(2000);
            actions.deleteSkill(webdriver);
            Thread.Sleep(1000);
            webdriver.Quit();

        }



        [When(@"user clicks on delete button under Skills")]
        public void WhenUserClicksOnDeleteButtonUnderSkills()
        {
            Thread.Sleep(3000);
            actions.deleteSkill(webdriver);
            Thread.Sleep(1000);
            webdriver.Quit();
        }

        [Then(@"verify Skill is deleted")]
        public void ThenVerifySkillIsDeleted()
        {
            
        }

        [When(@"user clicks on Skillsedit button")]
        public void WhenUserClicksOnSkillseditButton()
        {
            Thread.Sleep(5000);
            actions.editSkill(webdriver);
        }

        [Then(@"verify Skill is edited")]
        public void ThenVerifySkillIsEdited()
        {
            Thread.Sleep(3000);
            
            actions.deleteSkill(webdriver);
            webdriver.Quit();
        }

        
    }
}
