using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoTests.Demo;
using Xunit;
using Moq;

namespace DemoTests.Controllers.Tests
{
    public class DemoControllerTests
    {
        [Fact]
        public void FindAsync()
        {
            // Arrange
            var mockRepo = new Mock<IDemoServices>();
            mockRepo.Setup(repo => repo.FindAsync()).Returns(Task.FromResult(GetTestSessions()));
            var controller = new DemoController(mockRepo.Object);

            // Act
            var result = controller.ListAsync();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<DemoModel>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

        private IEnumerable<DemoModel> GetTestSessions()
        {
            var sessions = new List<DemoModel>();
            sessions.Add(new DemoModel()
            {
                Id = 1,
                isAuthenticated = true
            });
            sessions.Add(new DemoModel()
            {
                Id = 2,
                isAuthenticated = false
            });
            return sessions;
        }
    }
}