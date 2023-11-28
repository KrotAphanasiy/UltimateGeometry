using UltimateGeometry.Utils;
using Xunit;

namespace UltimateGeometry.Tests;

public class AreaCalculatorTests
{
    [Fact]
    public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5;

        // Act
        double result = AreaCalculator.CalculateCircleArea(radius);

        // Assert
        Assert.Equal(78.54, result, 2);
    }

    [Fact]
    public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        // Act
        double result = AreaCalculator.CalculateTriangleArea(sideA, sideB, sideC);

        // Assert
        Assert.Equal(6, result, 2);
    }

    [Fact]
    public void IsRightTriangle_ValidSides_ReturnsTrue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        // Act
        bool result = AreaCalculator.IsRightTriangle(sideA, sideB, sideC);

        // Assert
        Assert.True(result);
    }
}
