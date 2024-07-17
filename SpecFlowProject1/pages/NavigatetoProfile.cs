using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowProject1.pages
{
    public class NavigatetoProfile
    { 
            public void NavigateProfile(IWebDriver webDriver)
            {
                IWebElement  clickonProfile = webDriver.FindElement(By.XPath("/html/body/div[1]/section[1]/div/a[2]"));
                clickonProfile.Click();
                IWebElement tmoption = webDriver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3]"));
                tmoption.Click();

            }
            //verify login user
            public void VerifyLoggedInUser(IWebDriver webDriver)
            {
                IWebElement LoginLink = webDriver.FindElement(By.XPath("/ html / body / div[1] / div[1] / div[2] / div / span"));
                if (LoginLink.Text == "Hi Lakshmi!")
                {
                    Console.WriteLine("user has logged in successfully");
                }
                else
                {
                    Console.WriteLine("user has not been logged in");
                }
            }
        }
    }


