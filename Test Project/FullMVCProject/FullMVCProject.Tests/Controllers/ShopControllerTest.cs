using System;
using System.Text;
using System.Collections.Generic;
using FullMVCProject.Models;
using System.Web.Mvc;
using FullMVCProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FullMVCProject.Tests.Controllers
{
    /// <summary>
    /// Summary description for ShopControllerTest
    /// </summary>
    [TestClass]
    public class ShopControllerTest
    {
        public ShopControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ProductName()
        {
            // Arrange
            ShopController controller = new ShopController();

            // Act
            ViewResult viewResult = controller.Product();
            ProductModel result = viewResult.Model as ProductModel;

            // Assert
            Assert.AreEqual("IPhone 6", result.Name);
        }

        [TestMethod]
        public void ProductIsBling()
        {
            // Arrange
            ShopController controller = new ShopController();
            // Act
            ViewResult result = controller.Product();
            // Assert
            Assert.AreEqual("Bling!", result.ViewBag.SubTitle);
        }
        [TestMethod]

        public void ProductIsCheapAndNasty()
        {
            // Arrange

            ProductModel model = new ProductModel();
            model.Name = "Test Product 1";
            model.Description = "Description of Test Product 1";
            model.Price = 2.99M;

            // Inject the controller's dependency on the model so we can test it

            ShopController controller = new ShopController(model);

            // Act

            ViewResult result = controller.Product();
            Assert.AreEqual("Cheap and nasty product!", result.ViewBag.SubTitle);

        }
    }
}
