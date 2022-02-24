
using Xunit;
using SuperExampleGame.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using System.Threading.Tasks;
using SuperExampleGame.API.Services;
using SuperExampleGame.API.Models;
using Moq;
using SuperExampleGame.API.Models.Levels;
using SuperExampleGame.API.Models.Interfaces;

namespace SuperExampleGame.UnitTests.Systems.Controllers
{
    public class UnitTest1
    {
        [Fact]
        public async Task Post_OnSuccess_ReturnsStatusCode200()
        {
            var mockWarriorService = new Mock<IWarriorService>();
            var warriorsController = new WarriorController(mockWarriorService.Object);

            var mockItem = new Mock<IItemEquipment>();
            var mockUser = new Mock<IUser>();

            var result = (OkObjectResult)await warriorsController.BuyItemToEquip(mockItem.Object,mockUser.Object);

            result.StatusCode.Should().Be(200);

        } 
        [Fact]
        public async Task Get_OnSuccess_ReturnsInitialWarrior()
        {
            var mockWarriorService = new Mock<IWarriorService>();

            mockWarriorService
                .Setup(service => service.GetInitialWarrior())
                .ReturnsAsync(new Warrior());

            var warriorsController = new WarriorController(mockWarriorService.Object);

            var result = await warriorsController.GetInitialWarrior();

            mockWarriorService.Verify(service => service.GetInitialWarrior(), Times.Once());

        } 
         [Fact]
        public async Task Get_OnNoWarriorFound_Returns404()
        {
            var mockWarriorService = new Mock<IWarriorService>();

            mockWarriorService
                .Setup(service => service.GetInitialWarrior())
                .ReturnsAsync(new Warrior());

            var warriorsController = new WarriorController(mockWarriorService.Object);
            var result = await warriorsController.GetInitialWarrior();

           result.Should().BeOfType<NotFoundResult>();

        } 
    }
}
