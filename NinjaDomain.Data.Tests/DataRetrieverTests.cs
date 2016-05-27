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
    
    public class DataRetrieverTests
    {
        IQueryable<Ninja> MockNinjaData;        
        Mock<DbSet<Ninja>> MockDbSet;
        Mock<INinjaContext> MockNinjaContext;

        IQueryable<Ninja> MockNinjaDataWithItems;
        Mock<DbSet<Ninja>> MockDbSetWithItems;
        Mock<INinjaContext> MockNinjaContextWithItems;

        public DataRetrieverTests()
        {
            SetupTests();
        }

        [Fact]
        public void GetAll_ReturnsListOfNinjas()
        {
            var sut = new NinjaRetriever(MockNinjaContext.Object);
            
            var ninjas = sut.GetAll();

            Assert.IsType<List<Ninja>>(ninjas);        
        }

        [Fact]
        public void GetAll_WithProductsInDataSet_ReturnsCorrectNumberOfItems()
        {
            var sut = new NinjaRetriever(MockNinjaContextWithItems.Object);

            var ninjas = sut.GetAll();

            Assert.Equal(3, ninjas.Count);    
        }

        private void SetupTests()
        {
            MockNinjaData = new List<Ninja>().AsQueryable();
            MockDbSet = new Mock<DbSet<Ninja>>();
            MockNinjaContext = new Mock<INinjaContext>();

            MockDbSet.As<IQueryable<Ninja>>()
                .Setup(m => m.GetEnumerator())
                .Returns(MockNinjaData.GetEnumerator());
            MockNinjaContext
                .Setup(c => c.Ninjas)
                .Returns(MockDbSet.Object);

            MockDbSetWithItems = new Mock<DbSet<Ninja>>();
            MockNinjaContextWithItems = new Mock<INinjaContext>();
            MockNinjaDataWithItems = new List<Ninja>
            {
                new Ninja { Name = "BBB" },
                new Ninja { Name = "ZZZ" },
                new Ninja { Name = "AAA" },
            }.AsQueryable();

            MockDbSetWithItems.As<IQueryable<Ninja>>()
                .Setup(m => m.GetEnumerator())
                .Returns(MockNinjaDataWithItems.GetEnumerator());
            MockNinjaContextWithItems
                .Setup(c => c.Ninjas)
                .Returns(MockDbSetWithItems.Object);
        }
    }
}
