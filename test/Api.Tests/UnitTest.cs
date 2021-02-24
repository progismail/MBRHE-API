using Api.Controllers;
using System;
using System.Linq;
using Xunit;

namespace Api.Tests
{
    public class UnitTest
    {

        [Fact]
        public void GetWeatherDataList_Success()
        {
            //Arrange
            var controller = new WeatherForecastByMBRHEController(null);

            //Act
            var weatherDataList = controller.Get().ToList();

            //Assert
            Assert.True(weatherDataList.Count > 0);
        }
    }
}
