namespace NinjaDomain.WebApi.Tests
{
    using System.Collections.Generic;
    using Xunit;
    using Moq;

    using Controllers;
    using Classes;
    using Data.Interfaces;

    public class NinjaControllerTests
    {      
        [Fact]
        public void Get_ReturnsListOfNinjas()
        {
            var mockDataRetriever = new Mock<IRetrieveData<Ninja>>();
            mockDataRetriever.Setup(x => x.GetAll()).Returns(new List<Ninja>());

            var sut = new NinjaController(mockDataRetriever.Object);

            var result = sut.Get();

            Assert.IsType<List<Ninja>>(result);
        }
    }
   



}
