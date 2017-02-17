using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCodTests.ControllerTests
{
    public class AccountControllerTest
    {

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Register_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Register();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Login_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Login();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
