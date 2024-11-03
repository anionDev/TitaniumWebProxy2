using TitaniumWebProxy2Backend.Core.Controller;
using TitaniumWebProxy2Backend.Core.Services;
using GRYLibrary.Core.Logging.GeneralPurposeLogger;
using GRYLibrary.Core.Misc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TitaniumWebProxy2Backend.Tests
{
    [TestClass]
    public class MyAPIControllerTests
    {
        [TestMethod]
        [TestProperty(nameof(TestKind), nameof(TestKind.UnitTest))]
        public void TestSomeFunction()
        {
            // arrange
            IMathService someService = new MathService();
            Mock<IPersistence> persistence = new Mock<IPersistence>();
            ExampleController controller = new ExampleController(someService, GeneralLogger.NoLog(), persistence.Object);
            decimal parameter1 = 2.5m;
            decimal parameter2 = 3m;
            decimal expectedResultValue = 5.5m;

            // act
            IActionResult actualResult = controller.Calculate("Add", parameter1, parameter2);

            // assert
            Assert.IsTrue(actualResult is OkObjectResult);
            decimal acturalResultValue = (decimal)(actualResult as OkObjectResult).Value;
            Assert.AreEqual(expectedResultValue, acturalResultValue);
        }
    }
}
