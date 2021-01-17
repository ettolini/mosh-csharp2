using System;

namespace ConstructorsInheritance
{
    public class Vehicle
    {
        private readonly int _vehicles;
        public Vehicle(int vehicles)
        {
            _vehicles = vehicles;
            System.Console.WriteLine(vehicles + " vehicles are being initialized.");
        }

        public void Drive()
        {
            _vehicles = 3;  // _vehicles is readonly, can only be assigned in a constructor
            System.Console.WriteLine("Driving " + _vehicles + " vehicles!");
        }
    }

    public class Car : Vehicle
    {
        public Car(int cars)  // Base Keyword sends a parameter to the Base Class' constructor (you can choose a constructor based on signature)
            : base(cars)    
        {
            System.Console.WriteLine("Car is being initialized.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // When we create a Car Object, the engine will first try to create a Vehicle Object.
            // If there are no Car constructors that match any Vehicle constructor, the instruction won't compile.
            Car car = new Car(2);
        }
    }
}
