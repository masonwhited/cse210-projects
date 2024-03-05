using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Learning05 World!"); */
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 8);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Black", 3, 9);
        shapes.Add(s2);

        Circle s3 = new Circle("Purple", 6);
        shapes.Add(s3);

        foreach (var shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}