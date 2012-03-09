using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FicheEngagementDepense;
using FicheEngagementDepense.Controllers;

namespace FicheEngagementDepense.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            FicheEngDepController controller = new FicheEngDepController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.AreEqual("Demande d'engagement de dépense", result.ViewBag.Titre);
        }

    }
}
