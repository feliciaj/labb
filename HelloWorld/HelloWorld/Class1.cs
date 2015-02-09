using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace HelloWorld
{
    public class TestClass
    {


        [Test]
        public void should_have_listpage()
        {
            using (var browser = new OpenQA.Selenium.Firefox.FirefoxDriver())
            {
                browser.Navigate().GoToUrl("http://talangmvc/consultant");
                Assert.That(browser.FindElementsByCssSelector("table tr td"), Is.Not.Empty);
                browser.Close();
            }
        }

        [Test]
        public void should_have_createNew()
        {
            using (var browser = new OpenQA.Selenium.Firefox.FirefoxDriver())
            {
                browser.Navigate().GoToUrl("http://talangmvc/consultant");
                browser.FindElementByLinkText("Create New").Click();
                Assert.That(browser.Url, Is.EqualTo("http://talangmvc/consultant/Create"));
                browser.Close();
            }
        }
        [Test]
        public void should_have_edit()
        {
            using (var browser = new OpenQA.Selenium.Firefox.FirefoxDriver())
            {
                browser.Navigate().GoToUrl("http://talangmvc/consultant");
                browser.FindElementByLinkText("Edit").Click();
                Assert.That(browser.Url, Is.StringMatching("http://talangmvc/consultant/Edit/\\d+"));
                browser.Close();
            }
        }

        [Test]
        public void should_have_Details()
        {
            using (var browser = new OpenQA.Selenium.Firefox.FirefoxDriver())
            {
                browser.Navigate().GoToUrl("http://talangmvc/consultant");
                browser.FindElementByLinkText("Details").Click();
                Assert.That(browser.Url, Is.StringMatching("http://talangmvc/consultant/Details/\\d+"));
                browser.Close();
            }
        }

        [Test]
        public void should_have_Delete()
        {
            using (var browser = new OpenQA.Selenium.Firefox.FirefoxDriver())
            {
                browser.Navigate().GoToUrl("http://talangmvc/consultant");
                browser.FindElementByLinkText("Delete").Click();
                Assert.That(browser.Url, Is.StringMatching("http://talangmvc/consultant/Delete/\\d+"));
                browser.Close();
            }
        }

    }
}