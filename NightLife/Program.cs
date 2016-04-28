using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightLife
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            var performances = new Dictionary<string, SortedDictionary<string, List<string>>>();


            while (command != null && command.ToLower() != "end")
            {
                string[] comandArgs = command.Split(';');

                string city = comandArgs[0];
                string club = comandArgs[1];
                string performer = comandArgs[2];

                if (!performances.ContainsKey(city))
                {
                    performances.Add(city, new SortedDictionary<string, List<string>>());
                }
                if (!performances[city].ContainsKey(club))
                {
                    performances[city].Add(club, new List<string>());
                }
                if (!performances[city][club].Contains(performer))
                {
                performances[city][club].Add(performer);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine();

            foreach (var city in performances)
            {
                Console.WriteLine($"{city.Key}");

                foreach (var club in city.Value)
                {
                    club.Value.Sort();
                    Console.WriteLine($"->{club.Key}: {string.Join(", ", club.Value)} ");
                  
                }
            }
        }
    }
}
