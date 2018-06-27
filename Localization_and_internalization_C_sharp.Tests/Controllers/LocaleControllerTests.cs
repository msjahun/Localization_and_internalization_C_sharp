using Microsoft.VisualStudio.TestTools.UnitTesting;
using Localization_and_internalization_C_sharp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Localization_and_internalization_C_sharp.Controllers.Tests
{
    [TestClass()]
    public class LocaleControllerTests
    {
      


        [TestMethod]
        public void TestKoreanLocale()
        {
            // Arrange
            LocaleController controller = new LocaleController();

            // Act
            ViewResult result = controller.Change("ko") as ViewResult;

            // Assert
            Assert.AreEqual("12,345,678.00", result.ViewBag.NumberFormat);

        }

        [TestMethod]
        public void TestTurkishLocale()
        {
            // Arrange
            LocaleController controller = new LocaleController();

            // Act
            ViewResult result = controller.Change("de") as ViewResult;

            // Assert
            Assert.AreEqual("12,345,678.00", result.ViewBag.NumberFormat);

        }

        [TestMethod]
        public void TestDutchLocale()
        {
            // Arrange
            LocaleController controller = new LocaleController();

            // Act
            ViewResult result = controller.Change("de") as ViewResult;

            // Assert
            Assert.AreEqual("12,345,678.00", result.ViewBag.NumberFormat);

        }


    }
}