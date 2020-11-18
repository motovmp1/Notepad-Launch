using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;
using System.Threading;
using System.Security.Policy;
using OpenQA.Selenium.Remote;
using NUnit.Framework;

namespace LaunchNotepad
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void LaunchNotepadAndWriteSomething() 
        {
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = (@"C:\Windows\System32\notepad.exe");

            WiniumDriver driver = new WiniumDriver(@"C:\Users\User01\Downloads\Winium.Desktop.Driver", options);

            Thread.Sleep(2000);
            driver.FindElementByClassName("Edit").SendKeys("Eliza");
            Thread.Sleep(2000);
            driver.FindElementByName("File").Click();
            Thread.Sleep(2000);
            driver.FindElementById("Close").Click();
            Thread.Sleep(2000);
            driver.FindElementByName("Don't Save").Click();





            
            




        }
    }
}
