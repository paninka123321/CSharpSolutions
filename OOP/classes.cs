using System;

namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string toSomeone)
        {
            Console.WriteLine($"Hello {toSomeone}, my name is {Name}.");
        }

        public static Person Parse(string input)
        {
            var person = new Person();
            person.Name = input;

            return person;
        }
    }

    public class Program
        {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Alice";
            person.Introduce("Bob");

            var person2 = Person.Parse("Bob"); // Using the static Parse method
            person2.Introduce("Alice");
            }
        }
}