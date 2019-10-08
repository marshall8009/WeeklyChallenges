using System;

namespace ExtensionMethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jake Marshall.";
            "Hello World".Print();
            myName.Print();

            myName.Excite().Print();

            double output = 4.15.Add(5).Subtract(2).MultilyBy(8).DivideBy(3).Add(34);
            Console.WriteLine(output);

            PersonModel person = new PersonModel();

            person.Fill().Print();

            Console.ReadLine();
        }
    }
}
