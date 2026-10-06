class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);

        Console.WriteLine("PI = " + Circle.PI);
        Console.WriteLine("Area = " + circle.CalculateArea());
        Console.WriteLine("Perimeter = " + circle.CalculatePerimeter());

        // Uncomment to see the compilation error:
        // Circle.PI = 3.14159;
    }
}



class Circle
{
    public const double PI = 3.14;

    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * PI * Radius;
    }
}