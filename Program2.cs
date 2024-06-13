using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.WebAuthn;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpFundamental_2
{
    internal class Program2
    {

        static void Main(string[] args)
        {

            //Configure the browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //Open the Browser
            IWebDriver driver = new ChromeDriver();



            //maximize
            driver.Manage().Window.Maximize();


            //url
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

            driver.FindElement(By.CssSelector("input[name = 'username']")).SendKeys("see");

            driver.FindElement(By.CssSelector("#password")).SendKeys("Dash");

            driver.FindElement(By.CssSelector("#terms")).Click();

            //tagname[Attribute = 'value']

            driver.FindElement(By.CssSelector("input[value='Sign In'")).Click(); //Sign In

            Thread.Sleep(3000);

            //Exact Time
            //Test Fail 
            //Time Consumption is more


           string text = driver.FindElement(By.XPath("//form[@id='login-form']/div/strong/..")).Text;

            Console.WriteLine(text);


            driver.Quit();

        }
       
        
    }
}
