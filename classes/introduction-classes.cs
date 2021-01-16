using System;

namespace IntroductionClasses
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

    }

    public class Person2
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Pleased to meet you, {0}. The name's {1}!", to, Name);
        }

        public static Person2 Parse(string str)
        {
            var person = new Person2();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();   // Here we define a person object with the Person class, as usual
            person.Name = "Ettore";         // Notice how the Introduce method receives the other person's name as a parameter
            person.Introduce("Joaquin");

            Person2 p = Person2.Parse("Kaxel"); // Here we use a defined Parse Method so we give it a string, and with that string,
            p.Introduce("some dude");           // it creates a new Person2 object, which we store in a p variable
        }
    }
}
