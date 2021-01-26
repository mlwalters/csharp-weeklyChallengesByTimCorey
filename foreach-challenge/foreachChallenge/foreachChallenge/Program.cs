using System;
using System.Collections.Generic;

namespace foreachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            List<string> familyDogs = new List<string>
            {
                "Louie",
                "Lucy",
                "Sunshine",
                "Smores",
                "Blackie",
                "Brownie",
                "Ziggy"
            };


            foreach(string dogName in familyDogs)
            {
                Console.WriteLine($"Hello, {dogName}!");
            }

            List<Name> names = new List<Name>()
            {
                new Name("Maya", "Angelou"),
                new Name("Jane", "Austen"),
                new Name("Leo", "Tolstoy"),
                new Name("Jose", "Rizal"),
            };
                  foreach(Name author in names)
            {
                Console.WriteLine($"{author.FirstName} {author.LastName} is a fantastic author.");
            }
        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
