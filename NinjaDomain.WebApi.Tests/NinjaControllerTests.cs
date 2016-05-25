namespace NinjaDomain.WebApi.Tests
{
    using Controllers;
    using Xunit;
    using System.Collections.Generic;
    using Classes;

    public class NinjaControllerTests
    {
        [Fact]
        public void Get_ReturnsListOfNinjas()
        {
            var sut = new NinjaController();

            var result = sut.Get();

            Assert.IsType<List<Ninja>>(result);
        }
    }
}
