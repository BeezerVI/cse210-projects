using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shapes> shapes = new List<Shapes>();

        Square shape1 = new Square("green", 5);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("yellow", 10, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("purple", 3);
        shapes.Add(shape3);

        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}