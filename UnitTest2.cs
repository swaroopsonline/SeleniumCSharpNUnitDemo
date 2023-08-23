using OpenQA.Selenium;




namespace csharp_practice;


public class Test:TestSetup
{

   
    [Test]
    public void Test1()
    {
        Assert.Fail();
    }

    [Test]
    public void Test2()
    {
       driver.Url = "https://www.way2automation.com/angularjs-protractor/banking/#/login";
    //    Thread.Sleep(2000);
       
       driver.FindElement(By.XPath("//button[contains(text(), 'Bank Manager Login')]")).Click();
    }

   
}