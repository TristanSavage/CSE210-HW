using System;
using System.Globalization;
using System.Runtime.InteropServices;


class Kitchen
{
    public Dishwasher _dishwasher;
    public Toaster _toaster;
    public Table _table;
    public Sink _sink;

}

class Toaster
{
`
}

class Dishwasher
{

}

class Sink
{

}

class Table
{
    public bool isExtended = false;
    public List<Chair> _chairs = new List<Chair>();
}

class Chair
{
    public string _color;
}

class Program
{
    static void Main(string[] args)
    {
        Kitchen myKitchen = new Kitchen();
        myKitchen._dishwasher = new Dishwasher();
        myKitchen._sink = new Sink();

        myKitchen._toaster = new Toaster();

        myKitchen._table = new Table();
        myKitchen._table.isExtended = false;
        Chair chair1 = new Chair();
        chair1._color = "brown";
        Chair chair2 = new Chair();
        chair2._color = "brown";
        myKitchen._table._chairs.Add(chair1);
        myKitchen._table._chairs.Add(chair2);
    
    }



}

// class Box
// {
//     public double _height = 0;
//     public double _width = 0;
//     public double _length = 0;

//     public string _unit = "";

//     public string Describe()
//     {
//         return $"Box + {_length} + {_width} + {_height} {_unit}";
//     }

//     public double Volume()
//     {
//         return _length * _width * _height;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         Box small = new Box();
//         small._length = 10;
//         small._width = 7;
//         small._height = 5;
//         small._unit = "in";

//         Console.WriteLine(small.Describe());

//         Console.WriteLine(small.Volume());

        // int x;
        // x = 10;
        // Console.WriteLine(x);

        // float y = 5;
        // Console.WriteLine(y);

        // Console.Write("There will not be a newline after this.");

        // Console.WriteLine("Hello World!");

        // // Console.Write("What is your favorite color? ");
        // // string color = Console.ReadLine();

        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}.");

        // if (x > y)
        //     {
        //     Console.WriteLine("greater than");
        //     }
        
        // if (x > y)
        //     {
        //         Console.WriteLine("greater than");
        //     }
        //     else
        //     {
        //         Console.WriteLine("less than");
        //     }

        // if (x > y)
        //     {
        //         Console.WriteLine("greater than y");
        //     }
        //     else if (x > z)
        //     {
        //         Console.WriteLine("greater than z");
        //     }
        //     else
        //     {
        //         Console.WriteLine("less than both");
        //     }

        


    }
}