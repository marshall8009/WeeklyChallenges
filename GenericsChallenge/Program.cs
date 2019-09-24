using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list1 = new List<string>
            //{
            //    "Item jedno",
            //    "Item dva",
            //    "Item tri",
            //    "Item ctyri",
            //    "Item pet"
            //};
            //List<string> list2 = new List<string>
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3",
            //};

            //var result = MergeLists(list2, list1);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            Person person = new Person { Title = "Jacob", Name = "Jake Marshall" };
            Address address = new Address { Title = "RC", City = "Rancho Cucamonga" };

            var result = DetermineLongerTitle(person, address);
            Console.WriteLine(result.Title);

            Console.ReadLine();
        }

        private static List<T> MergeLists<T>(List<T> list1, List<T> list2)
        {
            List<T> output = new List<T>();
            List<T> largerList;
            List<T> smallerList;

            if (list1.Count > list2.Count)
            {
                largerList = list1;
                smallerList = list2;
            }
            else
            {
                largerList = list2;
                smallerList = list1;
            }

            int smallerCount = smallerList.Count;

            for (int i = 0; i < largerList.Count; i++)
            {
                output.Add(largerList[i]);

                if (i < smallerCount)
                {
                    output.Add(smallerList[i]);
                }
            }

            return output;
        }

        private static IHaveTitle DetermineLongerTitle<T, U>(T item1, U item2) where T : IHaveTitle 
                                                                               where U : IHaveTitle
        {
            if (item1.Title.Length > item2.Title.Length)
            {
                return item1;
            }
            else
            {
                return item2;
            }
        }
    }
}
