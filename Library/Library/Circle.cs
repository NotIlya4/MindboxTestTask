namespace MindboxTestTaskLibrary;

public class Circle : IShape
{
    public double Radius { get; }
    
    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius cannot be negative or null");
        }
        
        Radius = radius;
    }
}