namespace NinjaDomain.Data.Tests
{
    using Xunit;
    using System.Collections.Generic;

    using Classes;
    using Services;
    
    public class DataRetrieverTests
    {
        [Fact]
        public void GetAll_ReturnsListOfNinjas()
        {
            var sut = new NinjaRetriever();

            var result = sut.GetAll();

            Assert.IsType<List<Ninja>>(result);
        }
    }
}
