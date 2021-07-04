using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = pangrams(s);

            Console.WriteLine(result);
        }

        private static string pangrams(string s)
        {
            s = s.Replace(" ", string.Empty);
            HashSet<char> myAlphapet = new HashSet<char>();

            foreach (var item in s.ToLower())
            {
                myAlphapet.Add(item);

            }
            if (myAlphapet.Count == 26)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }
    }
}
