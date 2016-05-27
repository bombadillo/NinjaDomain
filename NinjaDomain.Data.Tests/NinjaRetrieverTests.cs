namespace NinjaDomain.Data.Tests
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using Xunit;
    using Moq;
    using System.Linq;

    using Classes;
    using Services;
    using Contexts;
    using System;
    
    public class NinjaRetrieverTests
    {
        IQueryable<Ninja> MockNinjaData;        
        Mock<DbSet<Ninja>> MockDbSet;
        Mock<INinjaContext> MockNinjaContext;

        IQueryable<Ninja> MockNinjaDataWithItems;
        Mock<DbSet<Ninja>> MockDbSetWithItems;
        Mock<INinjaContext> MockNinjaContextWithItems;

        public NinjaRetrieverTests()
        {
            SetupTests();
        }

        [Fact]
        public void GetAll_ReturnsListOfNinjas()
        {
            var sut = new NinjaRepository(MockNinjaContext.Object);
            
            var ninjas = sut.GetAll();

            Assert.IsType<List<Ninja>>(ninjas);        
        }

        [Fact]
        public void GetAll_WithProductsInDataSet_ReturnsCorrectNumberOfItems()
        {
            var sut = new NinjaRepository(MockNinjaContextWithItems.Object);

            var ninjas = sut.GetAll();

            Assert.Equal(3, ninjas.Count);    
        }

        [Fact]
        public void GetOne_WhenDataExists_ReturnsOneNinja()
        {
            var sut = new NinjaRepository(MockNinjaContextWithItems.Object);

            var ninja = sut.GetOne(1);

            Assert.Equal(1, ninja.Id);
        }

        private void SetupTests()
        {
            MockNinjaData = new List<Ninja>().AsQueryable();
            MockDbSet = new Mock<DbSet<Ninja>>();
            MockNinjaContext = new Mock<INinjaContext>();

            MockDbSet.As<IQueryable<Ninja>>()
                .Setup(m => m.GetEnumerator()).Returns(MockNinjaData.GetEnumerator());

            MockNinjaContext
                .Setup(c => c.Ninjas).Returns(MockDbSet.Object);

            MockDbSetWithItems = new Mock<DbSet<Ninja>>();
            MockNinjaContextWithItems = new Mock<INinjaContext>();
            MockNinjaDataWithItems = new List<Ninja>
            {
                new Ninja { Id = 1, Name = "BBB" },
                new Ninja { Id = 2, Name = "ZZZ" },
                new Ninja { Id = 3, Name = "AAA" },
            }.AsQueryable();

            MockDbSetWithItems.As<IQueryable<Ninja>>()
                .Setup(m => m.GetEnumerator()).Returns(MockNinjaDataWithItems.GetEnumerator());
            MockDbSetWithItems.As<IQueryable<Ninja>>()
                .Setup(m => m.Provider).Returns(MockNinjaDataWithItems.Provider);
            MockDbSetWithItems.As<IQueryable<Ninja>>()
                .Setup(m => m.Expression).Returns(MockNinjaDataWithItems.Expression);            

            MockNinjaContextWithItems
                .Setup(c => c.Ninjas)
                .Returns(MockDbSetWithItems.Object);
        }
    }
}
