using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Amazon.CloudFormation;
using System.IO;
using System.Reflection;

namespace automation
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            string currentUser = System.Environment.UserName; //read the Logged in user name
            ChromeOptions chroptions = new ChromeOptions();
            chroptions.AddArguments("--noerrdialogs");
            //chroptions.AddArguments(@"user-data-dir=C:\Users\" + currentUser + @"\AppData\Local\Google\Chrome\User Data");

            chroptions.AddAdditionalOption("useAutomationExtension", false);
            chroptions.AddArgument("no-sandbox");
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chroptions, TimeSpan.FromMinutes(3));
      
            
            string page_url = "file:///C:/Users/levid/Documents/test%20page.html";
            //string page_url = "https://root:root@192.168.1.107/cgi-bin/minerConfiguration.cgi";
            
            driver.Navigate().GoToUrl(page_url);
            Thread.Sleep(1000);
            


            string usa_west_string = "stratum+tcp://scrypt.usa-west.nicehash.com:3333";
            string usa_east_string = "stratum+tcp://scrypt.usa-east.nicehash.com:3333";
            string europe_west_string = "stratum+tcp://scrypt.eu-west.nicehash.com:3333";

            string worker_url = "3MG7VkVQ1HHHK5aJCT2PrnWY7VacEHZJf6.worker2";



            Thread.Sleep(2000);
            //pool 1 details          
            driver.FindElement(By.Name("cbid.cgminer.default.pool1url")).Clear();
            driver.FindElement(By.Name("cbid.cgminer.default.pool1url")).SendKeys(usa_west_string);
            //worker1 details
            driver.FindElement(By.Name("cbid.cgminer.default.pool1user")).Clear();
            driver.FindElement(By.Name("cbid.cgminer.default.pool1user")).SendKeys(worker_url);


            //pool 2 details            
            driver.FindElement(By.Name("cbid.cgminer.default.pool2url")).Clear();
            driver.FindElement(By.Name("cbid.cgminer.default.pool2url")).SendKeys(usa_east_string);
            //worker1 details
            driver.FindElement(By.Name("cbid.cgminer.default.pool2user")).Clear();
            driver.FindElement(By.Name("cbid.cgminer.default.pool2user")).SendKeys(worker_url);


            //pool 3 details            
            driver.FindElement(By.Name("cbid.cgminer.default.pool3url")).Clear();
            driver.FindElement(By.Name("cbid.cgminer.default.pool3url")).SendKeys(europe_west_string);
            //worker1 details
            driver.FindElement(By.Name("cbid.cgminer.default.pool3user")).Clear();
            driver.FindElement(By.Name("cbid.cgminer.default.pool3user")).SendKeys(worker_url);


            driver.FindElement(By.ClassName("cbi-button-save")).Click();
            
            //driver.FindElement(By.Name("testin_name")).Click();

        }

        
    }

}
