// - Abstract members don't include implementation, they're only declarated.
// - If a member is declared as abstract, the containing class must be declarated as abstract as well.
// - Derived classes must implement all abstract members in the base abstract class.
// - Abstract classes cannot be instanciated. Example: var shape = new Shape(); -> Assuming Shape is an abstract class, this won't compile. 

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shape into clipboard.");       
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
        }
    }
}
