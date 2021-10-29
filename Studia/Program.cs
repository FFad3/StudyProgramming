using System;
using System.Collections.Generic;

namespace Studia
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessPeople();
        }

        public static void ProcessPeople()
        {
            var people = GetPeaople(1_000_000);
            foreach (var person in people)
            {
                if (person.Id < 1000)
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
                else
                    break;
            }
        }

        public static IEnumerable<Person> GetPeaople(int count)
        {
            List<Person> people = new();
            for (int i = 0; i <count; i++)
            {
                people.Add(new Person() { Id = i, Name = $"Name {i}" });
            }
            return people;
        }
    }
}
