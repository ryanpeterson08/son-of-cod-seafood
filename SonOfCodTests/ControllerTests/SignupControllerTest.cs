using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCodTests.ControllerTests
{
    public class SignupControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            SignupController controller = new SignupController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Fail_Test()
        {
            //Arrange
            SignupController controller = new SignupController();

            //Act
            var result = controller.Fail();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            //Arrange
            SignupController controller = new SignupController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_Mailing_List_Test()
        {
            SignupController controller = new SignupController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsType<List<Signup>>(result);
        }

    }
}
