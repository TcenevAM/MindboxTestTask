using ShapesLibrary.Entities;

namespace ShapesLibraryTests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        var radius = 5.0;
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        var circle = new Circle(radius);

        // Act
        var actualArea = circle.CalculateArea();

        // Assert
        Assert.Equal(expectedArea, actualArea, precision: 6);
    }

    [Fact]
    public void CalculateArea_ZeroRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = 0.0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Fact]
    public void CalculateArea_NegativeRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = -5.0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}