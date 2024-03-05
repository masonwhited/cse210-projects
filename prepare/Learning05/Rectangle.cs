public class Rectangle : Shape
{
    private double width;
    private double length;
    // Constructor
    public Rectangle(string color, double width, double length) : base(color)
    {
        this.width = width;
        this.length = length;
    }
    public override double GetArea()
    {
        return width * length;
    }
}