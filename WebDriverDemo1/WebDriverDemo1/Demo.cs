using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo1
{
    class Demo
    {
        IWebDriver driver;


        [Test]
        public void test()
        {
            String homeURL = "http://www.google.com";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver,System.TimeSpan.FromSeconds(15));


            //wait.Until(driver =>driver.FindElement(By.XPath("//a[@href='/beta/login']")));


            //IWebElement element =driver.FindElement(By.XPath("//a[@href='/beta/login']"));
            //Assert.AreEqual("Sign In", element.GetAttribute("text"));
        }

    }

}
