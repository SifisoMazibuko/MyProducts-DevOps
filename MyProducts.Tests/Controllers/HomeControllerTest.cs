using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProducts.WebApi;
using MyProducts.WebApi.Controllers;
using System.Diagnostics.CodeAnalysis;
using SoftwareApproach.TestingExtensions;

namespace MyProducts.Tests.Controllers
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
