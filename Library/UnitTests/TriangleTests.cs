using MindboxTestTaskLibrary;

namespace UnitTests;

public class TriangleTests
{
    [Theory]
    [InlineData(10.97, 4, 5.5, 7)]
    [InlineData(1.09, 1.3, 2, 1.7)]
    public void Area_ValidSides_CalculateArea(double expect, double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        double result = triangle.Area;

        Assert.Equal(expect, result, 0.01);
    }

    [Theory]
    [InlineData(0, 2, 3)]
    [InlineData(1, -1, 2)]
    public void Constructor_InvalidSides_Throw(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void IsRight_RightTriangle_True()
    {
        var triangle = new Triangle(3, 4, 5);

        bool result = triangle.IsRight();

        Assert.True(result);
    }
    
    [Fact]
    public void IsRight_NotRightTriangle_False()
    {
        var triangle = new Triangle(4, 5, 6);

        bool result = triangle.IsRight();

        Assert.False(result);
    }
}