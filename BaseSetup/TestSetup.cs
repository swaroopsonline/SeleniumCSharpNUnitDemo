using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace csharp_practice;

public class TestSetup{

 public IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }

    [TearDown]
    public void Close(){

        driver.Close();

    }


}