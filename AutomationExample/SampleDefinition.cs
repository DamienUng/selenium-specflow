using TechTalk.SpecFlow;
  
namespace AutomationExample
{
	[Binding]
	class Navigation
	{
		
		public static string searchXpath = "//input[@id='search_form_input_homepage']";
		public static string searchInputButton = "//input[@id='search_button_homepage']";
		
		[Given(@"I go to url (.*)")]
		public void OpenUrl(string Url) {
			Events.Driver.Navigate().GoToUrl(Url);
		}
		
		[Given(@"I search for (.*)")]
		public void SearchFor(string searchTerm) {
			Events.Driver.FindElementByXPath(searchXpath).SendKeys(searchTerm);
			Events.Driver.FindElementByXPath(searchInputButton).Click();
		}
		
		
	}
}