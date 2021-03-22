using System;
using System.Collections.Generic;
using System.Linq;

namespace Study_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            One(numbers);
            Console.WriteLine("-----");

            Two(numbers);
            Console.WriteLine("-----");
        }

        private static void One(List<int> numbers)
        {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exists)
                Console.WriteLine("存在します");
            else
                Console.WriteLine("存在しません");
        }

        private static void Two(List<int> numbers)
        {
            double s = 2.0;
            foreach (double num in numbers)
            {
                var n = num / s;
                Console.WriteLine(n);
            }
        }
    }
}
