using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            var collectin = new SortedDictionary<char, int>();


            for (int i = 0; i < input.Length; i++)
            {

                if (collectin.ContainsKey(input[i]))
                {
                    collectin[input[i]]++;
                }
                else
                {
                    collectin[input[i]] = 1;

                }
            }

            foreach (var pair in collectin)
            {

                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
        }
    }
}

