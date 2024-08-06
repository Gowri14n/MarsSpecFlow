using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using SpecFlowProject1.pages;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    
    
    public class LanguageActionsStepDefinitions
    {
        LoginMars login = new LoginMars();
        IWebDriver webdriver =new EdgeDriver();
        AddnEditandDeletelanguages actions = new AddnEditandDeletelanguages();
        
        [Given(@"user logins to Marsproject")]
        public void GivenUserLoginsToMarsproject()
        {
            login.LoginActions(webdriver);
            
            
        }

        [When(@"user clicks on Add new button under languages")]
        public void WhenUserClicksOnAddNewButtonUnderLanguages()
        {
            actions.AddLanguages(webdriver);
            
        }
        [When(@"user enters language andproficiency level '([^']*)'")]
        public void WhenUserEntersLanguageAndproficiencyLevel(string code)
        {

            actions.addLanguageandProficiency(webdriver, code);
        }



        [When(@"user clicks on addbutton")]
        public void WhenUserClicksOnAddbutton()
        {
            
        }

        [Then(@"verify language is added")]
        public void ThenVerifyLanguageIsAdded()
        {
            //actions.Verifylanguageadded(webdriver);
            Thread.Sleep(2000);
            actions.deleteLanguage(webdriver);


        }
        [When(@"user clicks on edit button")]
        public void WhenUserClicksOnEditButton()
        { 
            Thread.Sleep(5000);
            actions.editLanguages(webdriver);
        }



        [Then(@"verify language is edited")]
        public void ThenVerifyLanguageIsEdited()
        {
            Thread.Sleep(3000);
            actions.verifyLanguageUpdated(webdriver);
            actions.deleteLanguage(webdriver);
            webdriver.Quit();
           
        }
        [When(@"user clicks on delete button under languages")]
        public void WhenUserClicksOnDeleteButtonUnderLanguages()
            
        {
            Thread.Sleep(3000);
            
            actions.deleteLanguage(webdriver);
        }


        [Then(@"verify language is deleted")]
        public void ThenVerifyLanguageIsDeleted()
        {
            throw new PendingStepException();
        }

       
      
       

    }
}
