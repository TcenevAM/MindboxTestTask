using ShapesLibrary.Entities;

namespace ShapesLibraryTests;

public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            const double sideA = 6.0;
            const double sideB = 5.0;
            const double sideC = 7.0;

            const double expectedArea = 14.696938;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 6);
        }

        [Fact]
        public void CalculateArea_ZeroSide_ThrowsArgumentException()
        {
            // Arrange
            const double sideA = 3.0;
            const double sideB = 0.0;
            const double sideC = 5.0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculateArea_NegativeSide_ThrowsArgumentException()
        {
            // Arrange
            const double sideA = 3.0;
            const double sideB = -4.0;
            const double sideC = 5.0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculateArea_NotValidTriangle_ThrowsArgumentException()
        {
            // Arrange
            const double sideA = 3.0;
            const double sideB = 4.0;
            const double sideC = 8.0; 

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculateArea_RightTriangle_ReturnsCorrectArea()
        {
            // Arrange
            const double sideA = 3.0;
            const double sideB = 4.0;
            const double sideC = 5.0;

            const double expectedArea = 6.0;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 6);
        }
    }