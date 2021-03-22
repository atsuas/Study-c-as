using System;
using System.Collections.Generic;
using System.Linq;

namespace Study_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            One(names);
            Console.WriteLine("-----");

        }

        private static void One(List<string> names)
        {
            Console.WriteLine("都市名を入力。空文字で終了");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);

        }
    }
}
