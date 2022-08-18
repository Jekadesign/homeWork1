using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TestProject1
{
	public class Tests
	{
		private IWebDriver driver;

		private readonly By _searchField = By.Name("q");
		private readonly By _pictureButton = By.CssSelector("[data-hveid='CAEQAw']");
		

		[SetUp]
		public void Setup()
		{
			driver = new OpenQA.Selenium.Chrome.ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
			driver.Manage().Window.Maximize();
			
			//driver.FindElement(By.Name("q")).SendKeys("picture" + Keys.Enter);			
		}

		[Test]
		public void Test1()
		{
			driver.FindElement(_searchField).SendKeys("picture" + Keys.Enter);
			driver.FindElement(_pictureButton).Click();
			
		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}