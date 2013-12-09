using System;
using System.Resources;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutomationExample
{
    [Binding]
    public static class Events
    {
    	public static IWebDriver Driver;
   	
    	private static void Setup() {
    		var browser = "ie64bit";
    		
    		switch(browser) {
    			case "firefox":
    				Driver = new FirefoxDriver();
    				break;
    			case "ie64bit":
    				Driver = new InternetExplorerDriver();
    				break;
    		}
    	}
    	
        [BeforeFeature]
        public static void BeforeFeature()
        {
        	Setup();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Dispose();
        }
         

    }
    

}
