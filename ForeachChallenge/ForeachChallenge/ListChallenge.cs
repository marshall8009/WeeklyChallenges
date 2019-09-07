using System;
using System.Collections.Generic;
using System.Text;

namespace ForeachChallenge
{
    public class ListChallenge
    {
        public static void DisplayPersonList()
        {
            List<string> people = GetPeople();

            foreach (string person in people)
            {
                Console.WriteLine($"Hello { person }.");
            }
        }

        public static void DisplayPeopleModel()
        {
            List<PersonModel> people = GetPeopleModel();

            foreach (PersonModel person in people)
            {
                Console.WriteLine($"Hello { person.FirstName } { person.LastName }.");
            }
        }

        public static List<PersonModel> GetPeopleModel()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Anakin", LastName = "Skywalker" });
            output.Add(new PersonModel { FirstName = "Jared", LastName = "Goff" });
            output.Add(new PersonModel { FirstName = "Isaac", LastName = "Bruce" });
            output.Add(new PersonModel { FirstName = "Bruce", LastName = "Banner" });
            output.Add(new PersonModel { FirstName = "Pepper", LastName = "Potts" });

            return output;
        }

        private static List<string> GetPeople()
        {
            List<string> output = new List<string>
            {
                "John Wayne",
                "Frodo Baggins",
                "Darth Vader",
                "Darth Maul",
                "Jack Sparrow",
                "Tony Stark",
                "James Dean",
                "Spongebob Squarepants"
            };

            return output;
        }
    }
}
