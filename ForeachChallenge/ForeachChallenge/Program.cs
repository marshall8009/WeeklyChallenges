using System;
using System.Collections.Generic;

namespace ForeachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> person = new List<PersonModel>();

            person.Add(new PersonModel { FirstName = "Bob", LastName = "Marley" });
            person.Add(new PersonModel { FirstName = "Rachel", LastName = "Greene" });
            person.Add(new PersonModel { FirstName = "Spongebob", LastName = "Squarepants" });
            person.Add(new PersonModel { FirstName = "Darth", LastName = "Vader" });
            person.Add(new PersonModel { FirstName = "Frodo", LastName = "Baggins" });
            person.Add(new PersonModel { FirstName = "Monica", LastName = "Geller" });

            foreach (PersonModel p in person)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName }");
            }

            Console.ReadLine();

            List<string> listOfNames = new List<string>
            {
                "Bob",
                "Sue",
                "Emily",
                "Mark"
            };

            foreach (string name in listOfNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
