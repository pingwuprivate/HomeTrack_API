using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeTrack_API
{
    public class Driver
    {
        //properties
        private static IWebDriver _webDriver;
        public static IWebDriver Instance
        {
            // ??= assigns the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.
            // The ??= operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
            //_webDriver is null then excute 'Create() method, otherwise using existing one
            get
            {
                return _webDriver ?? Create();
            }
        }
        //method
        private static IWebDriver Create()
        {
            _webDriver = new ChromeDriver();
            return _webDriver;
        }
        //open brower and maximize the browser in window
        public static void Initialise()
        {//Browser driver
            _webDriver = new ChromeDriver();
            //maximise window 
            Instance.Manage().Window.Maximize();
        }
        public static void Close()
        {
            if (_webDriver == null) return;
            _webDriver.Close();
            _webDriver.Quit();
        }


    }
}