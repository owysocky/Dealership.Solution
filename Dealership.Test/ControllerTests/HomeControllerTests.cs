using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Controllers;
using Dealership.Models;

namespace Dealership.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_CarList()
    {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Car>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      CarsController controller = new CarsController();

      //Act
      IActionResult view = controller.Create("2014", "MakeModel", "22000", "2000");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      CarsController controller = new CarsController();
      RedirectToActionResult actionResult = controller.Create("2014", "MakeModel", "22000", "2000") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
