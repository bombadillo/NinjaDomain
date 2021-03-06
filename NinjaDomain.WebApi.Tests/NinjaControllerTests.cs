﻿namespace NinjaDomain.WebApi.Tests
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
            var mockDataRepository = new Mock<IDataRepository<Ninja>>();
            mockDataRepository.Setup(x => x.GetAll()).Returns(new List<Ninja>());

            var sut = new NinjaController(mockDataRepository.Object);

            var result = sut.Get();

            Assert.IsType<List<Ninja>>(result);
        }

        [Fact]
        public void GetOne_ReturnsNinja()
        {
            var mockDataRepository = new Mock<IDataRepository<Ninja>>();
            mockDataRepository.Setup(x => x.GetOne(It.IsAny<int>())).Returns(new Ninja());

            var sut = new NinjaController(mockDataRepository.Object);

            var result = sut.Get(It.IsAny<int>());

            Assert.IsType<Ninja>(result);
        }

        [Fact]
        public void Add_CallsRepositoryAddMethod()
        {
            var mockDataRepository = new Mock<IDataRepository<Ninja>>();

            var sut = new NinjaController(mockDataRepository.Object);

            sut.Post(It.IsAny<Ninja>());

            mockDataRepository.Verify(m => m.Add(It.IsAny<Ninja>()), Times.Once());
        }
    }
   



}
