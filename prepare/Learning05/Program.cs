using System;

class Program
{
    // public  DisplayAttributes()
    // {

    // }

    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();
        
        Square square = new Square("Green",10);
        Rectangle rectangle = new Rectangle("Red",5,10);
        Circle circle = new Circle("Blue",12);

        shapesList.Add(square);
        shapesList.Add(rectangle);
        shapesList.Add(circle);

        foreach (Shape shape in shapesList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}, Area = {area}");
        }
    }
}