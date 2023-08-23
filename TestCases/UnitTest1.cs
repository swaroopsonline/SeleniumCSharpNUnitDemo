using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;




namespace csharp_practice;

[TestFixture]
public class Tests
{

    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }

    [Test]
    public void Test1()
    {
        driver.Url = "http://demo.guru99.com/selenium/guru99home/";
    }

    [Test]
    public void Test2()
    {       
       driver.Navigate().GoToUrl("https://www.way2automation.com/angularjs-protractor/banking/#/login");
    //    Thread.Sleep(2000);
       
       driver.FindElement(By.XPath("//button[contains(text(), 'Customer Login')]")).Click();
    }

    [TearDown]
    public void Close(){

        driver.Close();

    }
}