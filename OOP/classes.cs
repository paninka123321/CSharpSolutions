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
            var customerWithoutConstructorExample = new CustomerWithoutConstructorExample();
            System.Console.WriteLine($"Id with default constructor: {customerWithoutConstructorExample.Id}, \nName with default constructor: {customerWithoutConstructorExample.Name}");

            // Using the constructor with defult (set by us) parameters
            var customerWithConstructorExample = new CustomerWithConstructorExample();
            System.Console.WriteLine($"Id with created constructor with set by us default param: {customerWithConstructorExample.Id}, \nName with created constructor with set by us default param: {customerWithConstructorExample.Name}");

            // Using the constructor with parameters
            var customerWithConstructorExample2 = new CustomerWithConstructorExample(1, "John Doe");
            System.Console.WriteLine($"Id with constructor with parameters: {customerWithConstructorExample2.Id}, \nName with constructor with parameters: {customerWithConstructorExample2.Name}");
        }
        }
}