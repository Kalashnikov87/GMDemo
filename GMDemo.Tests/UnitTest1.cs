using System.Collections.Generic;
using System.Web.Mvc;
using GMDemo.Controllers;
using GMDemo.Logger;
using GMDemo.Models;
using GMDemo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GMDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private ILogger _logger;
        private Mock<IGmData> _mockRepo;


        [TestInitialize]
        public void InitializeTests()
        {
            // Moq Sample data
            _mockRepo = new Mock<IGmData>();
            _mockRepo.Setup(machineRepo => machineRepo.GetSampleData()).Returns(() =>
            {
                var machines = new List<GmModel>();
                for (var i = 0; i < 200; i++)
                    machines.Add(new GmModel
                    {
                        Amount = i,
                        CostPerUnit = i,
                        MachineDescription = $"This is machine {i}",
                        Total = i * i
                    });
                return machines;
            });
        }

        [TestMethod]
        public void Check_If_Controller_Method_Returns_The_Correct_View()
        {
            var controller = new GmController(_mockRepo.Object, _logger);
            var result = controller.Index() as ViewResult;
            if (result != null) Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void Check_If_The_Method_Returns_The_Correct_Amount_Of_Results()
        {
            var controller = new GmController(_mockRepo.Object, _logger);
            var actual = controller.GetGmData();
            var result = actual.Data as List<GmModel>;

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.Count);
        }


        [TestMethod]
        public void Check_If_The_Method_Returns_The_Correct_Amount_Of_Results2()
        {
            var controller = new GmController(_mockRepo.Object, _logger);
            var actual = controller.GetGmData();
            var result = actual.Data as List<GmModel>;

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.Count);
        }
    }
}