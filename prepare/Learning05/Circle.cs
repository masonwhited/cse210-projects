public class Circle : Shape
{
    private double radius;
    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return 2 * Math.PI * radius;
    }
}