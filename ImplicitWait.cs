using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpFundamental_2
{
    internal class ImplicitWait
    {
        static void Main(string[] args)
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //Open the Browser
            IWebDriver driver = new ChromeDriver();

            //Implicit Wait > Global Wait 
            //Time > 10 seconds 

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);

            //maximize
            driver.Manage().Window.Maximize();


            //url
            driver.Url = "https://www.hyrtutorials.com/p/waits-demo.html";

            driver.FindElement(By.CssSelector("#btn1")).Click();

            bool displayed = driver.FindElement(By.CssSelector("#txt1")).Displayed; //true false

            Console.WriteLine(displayed);

        }

    }
}
