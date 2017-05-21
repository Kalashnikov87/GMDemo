using System;
using System.Web.Mvc;
using GMDemo.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GMDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new GmController();
            var result = controller.Index() as ViewResult;
            if (result != null) Assert.AreEqual("Index", result.ViewName);
        }
    }
}
