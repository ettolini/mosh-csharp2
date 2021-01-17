using System;

namespace UpcastingDowncasting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text(); // Can access Text and Shape properties
            Shape shape = text;     // Can only access Shape properties

            text.Width = 200;   
            shape.Width = 100;  

            System.Console.WriteLine(text.Width);   // Returns 100, because text and shape share the same reference, but with different views
        }
    }
}
