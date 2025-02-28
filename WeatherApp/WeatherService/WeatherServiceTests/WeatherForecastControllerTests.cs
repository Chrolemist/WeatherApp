using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using WeatherService.Entities;
using WeatherService.Controllers;

namespace WeatherServiceTests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_Returns_A_List_Of_WeatherForecasts()
    {
        // Arrange
        ILogger<WeatherForecastController> logger = new Mock<ILogger<WeatherForecastController>>().Object;
        WeatherForecastController weatherForecastController = new WeatherForecastController(logger);

        // Act
        IEnumerable<WeatherForecast> result = weatherForecastController.Get();

        // Assert
        result.Should().NotBeNullOrEmpty();
    }
}