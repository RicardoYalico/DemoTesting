using DemoTests.Controllers;
using DemoTests.Demo;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
           // var fakeData = A.CollectionOfDummy<DemoModel>(0).AsEnumerable();
            var demoServices = A.Fake<IDemoServices>();
           // A.CallTo(() => demoServices.FindAsync()).Returns(Task.FromResult(fakeData));
            var controller = new DemoController(demoServices);

            var actionResult = controller.ListAsync();
            var returnStatus = actionResult.Result as OkObjectResult;

            Assert.Equal("200", returnStatus.StatusCode.ToString());
        }
    }
}
