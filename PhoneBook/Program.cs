using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('-').ToArray();
            var phoneBook = new Dictionary<string, string>();

            while (input[0] != "search".ToLower())
            {
                if (!phoneBook.ContainsKey(input[0]))
                {
                    phoneBook.Add(input[0], input[1]);
                }

                input = Console.ReadLine().Split('-').ToArray();
            }

            string name = Console.ReadLine();

            while (name != string.Empty)
            {
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }
              //  input = Console.ReadLine().Split('-').ToArray();
                name = Console.ReadLine();
            }
        }
    }
}