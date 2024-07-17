using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.utilities
{
    public class WaitUtilis
    {
        public static void WaitToBeVisible(IWebDriver webDriver, String locatorType, String locatorValue, int seconds) 
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));

            if(locatorType == "XPath")
            {

                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            
            
            }
            if (locatorType == "Id")
            {

                
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));


            }
            if (locatorType == "CssSelector")
            {

                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));


            }
            if (locatorType == "Name")
            {

                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));


            }





        }
    
            
            
            
            
            
            
            
            }

}
