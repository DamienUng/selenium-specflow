using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;

namespace AutomationExample
{
    [Binding]
    public static class Events
    {
    	public static FirefoxDriver Driver;
    	
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Driver = new FirefoxDriver();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Dispose();
        }
         

    }
    

}
