/* **********************************************************************************
 *
 * Copyright (c) Microsoft Corporation. All rights reserved.
 *
 * This source code is subject to terms and conditions of the Microsoft Permissive
 * License (MS-PL).
 *
 * You must not remove this notice, or any other, from this software.
 *
 * **********************************************************************************/
using NUnit.Framework;
using OpenQA.Selenium;
using Plasma.WebDriver;

namespace Plasma.Test.Functional.Caching
{
    [TestFixture]
    public class OutputCache
    {
        [Test]
        public void TimestampCheck()
        {
            /////////////////////////////////////////////////////////////////////////////
            // Test OutputCaching

            HtmlNavigator htmlFirst = HtmlNavigatorExtensions.Html(WebApplicationFixture.ProcessRequest("~/Caching/OutputCache.aspx"));
            string timestamp1 = htmlFirst.FindElement(By.Id("Label1")).InnerHtml();

            HtmlNavigator htmlSecond = HtmlNavigatorExtensions.Html(WebApplicationFixture.ProcessRequest("~/Caching/OutputCache.aspx"));
            string timestamp2 = htmlSecond.FindElement(By.Id("Label1")).InnerHtml();

            Assert.AreEqual(timestamp1, timestamp2);
        }
    }
}
