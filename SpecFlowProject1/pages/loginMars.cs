using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.pages
{
    public class LoginMars
    {
        public void LoginActions(IWebDriver webdriver)
        {
            webdriver.Manage().Window.Maximize();
            webdriver.Navigate().GoToUrl("http://localhost:5000");
            IWebElement signin = webdriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signin.Click();
            
            IWebElement usernameTextbox = webdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("luuksshmenadavati@gmail.com");
            Thread.Sleep(5000);
            IWebElement passwordTextbox = webdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Apple@123$");
            IWebElement loginButton = webdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button" ));
            loginButton.Click();
            Thread.Sleep(2000);
            
        }
        
    }
}
