using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48, 18 };

            One(numbers);
            Console.WriteLine("-----");

            Two(numbers);
            Console.WriteLine("-----");

            Three(numbers);
            Console.WriteLine("-----");

            Four(numbers);
            Console.WriteLine("-----");
        }

        private static void One(List<int> numbers)
        {
            foreach (var num in numbers.Where(n => n % 8 == 0 || n % 9 == 0))
            {
                if (num == num)
                {
                    Console.WriteLine($"{num} 8or9で割り切れます");
                }
                else
                {
                    Console.WriteLine("存在していません");
                }
            }
        }

        private static void Two(List<int> numbers)
        {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        private static void Three(List<int> numbers)
        {
            foreach (var num in numbers.Where(n => n >= 50))
            {
                Console.WriteLine(num);
            }
        }

        private static void Four(List<int> numbers)
        {
            foreach (var num in numbers.Select(n => n * 2).ToList())
            {
                Console.WriteLine(num);
            }
        }
    }
}
