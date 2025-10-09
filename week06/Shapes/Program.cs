using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sha1 = new Square("Green", 5);
        shapes.Add(sha1);

        Rectangle sha2 = new Rectangle("Blue", 3, 5);
        shapes.Add(sha2);

        Circle sha3 = new Circle("Purple", 2);
        shapes.Add(sha3);


        foreach (Shape sha in shapes)
        {
            string color = sha.GetColor();

            double area = sha.GetArea();

            Console.WriteLine($"The color is {color} and the area of the shape is {area}");
        }
    }
}