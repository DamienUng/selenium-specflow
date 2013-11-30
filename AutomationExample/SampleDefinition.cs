using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
  
namespace AutomationExample
{
	[Binding]
	class Navigation
	{
		
		public static string searchXpath = "//input[@id='search_form_input_homepage']";
		public static string searchInputButton = "//input[@id='search_button_homepage']";
		public static string searchResultLinks = "//div[@id='links']//h2/a";
		
		[Given(@"I go to url (.*)")]
		public void OpenUrl(string Url) {
			Events.Driver.Navigate().GoToUrl(Url);
		}
		
		[When(@"I search for (.*)")]
		public void SearchFor(string searchTerm) {
			Events.Driver.FindElementByXPath(searchXpath).SendKeys(searchTerm);
			Events.Driver.FindElementByXPath(searchInputButton).Click();
		}
		
		[Then(@"I see that the first (\d+) links have the words (.*) in them")]
		public void SearchFor(int linkCount, string searchTerm) {
			
			var searchTerms = searchTerm.Split(',');
			
			while (Events.Driver.FindElementsByXPath(searchResultLinks).Count < 50) {
				Events.Driver.Keyboard.PressKey(OpenQA.Selenium.Keys.End);
			}
			
			var linkElements = Events.Driver.FindElementsByXPath(searchResultLinks);

			for (var i=0; i < linkCount; i++) {
				Console.WriteLine("link index:" + i + "\nlink text:" + linkElements[i].Text);
				
				bool searchTermPresent = false;
				
				foreach (var term in searchTerms) {
					searchTermPresent = searchTermPresent || linkElements[i].Text.ToLower().Contains(term.ToLower());
					if (searchTermPresent == true) break;
				}
				
				Assert.True(searchTermPresent, "Expected any one of " + searchTerm + " to be present in " + linkElements[i].Text + ", but found none");
			}
		}
	}
}