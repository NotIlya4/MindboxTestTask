using MindboxTestTaskLibrary;

namespace UnitTests;

public class CircleTests
{
    [Theory]
    [InlineData(78.54, 5)]
    [InlineData(314.16, 10)]
    [InlineData(19.63, 2.5)]
    public void Area_ValidRadius_CalculateArea(double expect, double radius)
    {
        var circle = new Circle(radius);

        double result = circle.Area;
        
        Assert.Equal(expect, result, 0.01);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Constructor_InvalidRadius_Throw(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}