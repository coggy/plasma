using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plasma.Core;

namespace Plasma.Samples.MSTestLibrary.Caching
{
    [TestClass]
    public class OutputCache
    {
        [TestMethod]
        public void TimestampCheck()
        {
            /////////////////////////////////////////////////////////////////////////////
            // Test OutputCaching

            AspNetResponse responseFirst = WebApp.ProcessRequest("~/Caching/OutputCache.aspx");
            string timestamp1 = responseFirst.FindHtmlElementById("Label1").InnerHtml;

            AspNetResponse responseSecond = WebApp.ProcessRequest("~/Caching/OutputCache.aspx");
            string timestamp2 = responseSecond.FindHtmlElementById("Label1").InnerHtml;

            Assert.AreEqual(timestamp1, timestamp2);
        }
    }
}