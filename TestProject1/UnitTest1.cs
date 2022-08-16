using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1
{
	public class Tests
	{
		private IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			driver = new OpenQA.Selenium.Chrome.ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
			driver.Manage().Window.Maximize();
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}