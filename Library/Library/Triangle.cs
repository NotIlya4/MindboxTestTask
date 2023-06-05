namespace MindboxTestTaskLibrary;

public class Triangle : IShape
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public double Area => HeronFormula(FirstSide, SecondSide, ThirdSide);

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException("Sides cannot be negative or null");
        }
        
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }
    
    public bool IsRight(double tolerance = 0.00001)
    {
        double[] sides = { FirstSide, SecondSide, ThirdSide };
        Array.Sort(sides);

        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < tolerance;
    }

    private static double HeronFormula(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
            
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}