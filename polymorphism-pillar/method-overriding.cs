using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    public class Shape
    {
        public virtual void Draw()
        {
            System.Console.WriteLine("Draw a shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());       // "Draw a circle."
            shapes.Add(new Rectangle());    // "Draw a rectangle."
            shapes.Add(new Shape());        // "Draw a shape."

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);   
        }
    }
}
