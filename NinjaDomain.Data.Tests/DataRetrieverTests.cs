namespace NinjaDomain.Data.Tests
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using Xunit;
    using Moq;

    using Classes;
    using Services;
    using Contexts;
    
    public class DataRetrieverTests
    {
        [Fact]
        public void GetAll_ReturnsListOfNinjas()
        {
            var mockSet = new Mock<DbSet<Ninja>>();
            var mockNinjaContext = new Mock<INinjaContext>();
            mockNinjaContext.Setup(x => x.Ninjas).Returns(mockSet.Object);
            var sut = new NinjaRetriever(mockNinjaContext.Object);

            var result = sut.GetAll();

            Assert.IsType<List<Ninja>>(result);
        }
    }
}
