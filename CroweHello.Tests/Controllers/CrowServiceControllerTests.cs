using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHello.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CroweHello.Models;
using Moq;

namespace CroweHello.Controllers.Tests
{
    [TestClass()]
    public class CrowServiceControllerTests
    {
        [TestMethod()]
        public void SecretMessageTest()
        {
            //Arrange
            string expectedResult = "Hello World";

            var messageRepositoryMock = new Mock<ISecretMessageRepository>();
            messageRepositoryMock.Setup(m => m.GetDecryptedSecretMessage).Returns(expectedResult);

            var crowServiceController = new CrowServiceController(messageRepositoryMock.Object);
            
            //Act

            var result = crowServiceController.SecretMessage();

            //Assert

            Assert.IsTrue(result== expectedResult);
        }
    }
}