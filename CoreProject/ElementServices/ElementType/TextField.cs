﻿using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;

namespace Elements
{
     public class TextField : WebElement
    {
        public TextField(IWebDriver driver, By by) : base(driver, by)
        {
        }
        public TextField(IWebDriver driver, IWebElement element, By by) : base(driver, element, by)
        {
        }
        public string GetText(int maxSec = 60)
        {
            try
            {
                return WaitForElementToBePresent(maxSec).Text.Trim();
            }
            catch(Exception e)
            {
                return null;
            }
        }

    }
}
