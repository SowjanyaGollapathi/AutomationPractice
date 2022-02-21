using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace AutomationPractice
{
    public class Tests
    {

        //crreate reference for webdriver
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Test1()
        {

            //create a javascript executer
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            
            //Navigate or open the url 
            driver.Navigate().GoToUrl("http://automationpractice.com");

            //maximize the window
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
           

            //search for word dress
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//input[@id='search_query_top']")).SendKeys("dress");

            //click on the search button
            driver.FindElement(By.Name("submit_search")).Click();

            //In 'Sort By' drop down, choose 'Price: Lowest First'
            SelectElement dd = new SelectElement(driver.FindElement(By.Id("selectProductSort")));
            dd.SelectByIndex(1);

            //Click on the ‘More’ Button. It should open the details page. 
            driver.FindElement(By.XPath("//body/div[@id='page']/div[2]/div[1]/div[3]/div[2]/ul[1]/li[1]/div[1]/div[2]/div[2]/a[2]")).Click();

            
            //Click 'Add to Cart' button 
            driver.FindElement(By.XPath("//span[contains(text(),'Add to cart')]")).Click();
           
            //Take a screenshot of the product page
            Screenshot ss2 = ((ITakesScreenshot)driver).GetScreenshot();
            ss2.SaveAsFile("C:\\Users\\Dileep\\Desktop\\SSS\\Scrn2.png", ScreenshotImageFormat.Png);


            //Click on proceed to checkout
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//header/div[3]/div[1]/div[1]/div[4]/div[1]/div[2]/div[4]/a[1]/span[1]/i[1]")).Click();

            //Click Proceed to checkout 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/p[2]/a[1]/span[1]")).Click();

            driver.FindElement(By.Name("email")).SendKeys("sowjanyagollapathi17@gmail.com");
            driver.FindElement(By.Name("passwd")).SendKeys("sowjanya@17");
            driver.FindElement(By.Name("SubmitLogin")).Click();


            //Click on address page, 'Click Proceed to checkout' 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]")).Click();
              
            //Click on Agree terms of service and Click 'Proceed to checkout'             
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.Id("cgv")).Click();
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/form[1]/p[1]/button[1]/span[1]")).Click();

            //Click on Confirm my order
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body/div[@id='page']/div[2]/div[1]/div[3]/div[1]/div[1]/div[3]/div[2]/div[1]/p[1]/a[1]")).Click();

            //Display the message"Your order on My Store is complete"
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]")).Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//header/div[2]/div[1]/div[1]/nav[1]/div[2]/a[1]")).Click();
           

            //close all the opened browser
            //driver.Quit();


        }
    }
}