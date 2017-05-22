using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GMDemo.Controllers;
using GMDemo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GMDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_If_Controller_Method_Returns_The_Correct_View()
        {
            var controller = new GmController();
            var result = controller.Index() as ViewResult;
            if (result != null) Assert.AreEqual("Index", result.ViewName);
        }
       
        [TestMethod]
        public void Check_If_The_Method_Returns_The_Correct_Amount_Of_Results()
        {
            var controller = new GmController();
            var actual = controller.GetSomeData();
            var result = actual.Data as List<GmModel>;

            if (result != null)
            {
                Assert.AreEqual(75, result.Count);
                //Assert.AreEqual(9, result[0]);
                //Assert.AreEqual(4, result[1]);
                //Assert.AreEqual(7, result[2]);
            }
        }
    }
}
