using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YahooCommentary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://cricket.yahoo.net/scores/new-zealand-vs-england-2nd-test-29th-november-2019-nzen11292019190968-commentary";


            FunctionLibrary.MouseOver(driver, "/html/body/div[2]/myapp/section/section[2]/div/div/div/div[1]/div/section/component/div/div/div[4]/div[3]/div/div/div[2]/div[7]/div[2]/div[1]/div[1]");
        var str=    FunctionLibrary.ElementText(driver, "/html/body/div[2]/myapp/section/section[2]/div/div/div/div[1]/div/section/component/div/div/div[4]/div[3]/div/div/div[2]/div[3]/div/div[1]/div[2]");

            Console.WriteLine(str);


          var count=  driver.FindElements(By.CssSelector(".si-runCard")).Count;

            Console.WriteLine(count);

        }
    }
}
