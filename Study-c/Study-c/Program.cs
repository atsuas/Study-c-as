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
            var text = "Jackdaws love my big sphinx of quartz";

            One(text);
            Console.WriteLine("-----");

            Two(text);
            Console.WriteLine("-----");

            Three(text);
            Console.WriteLine("-----");

            Four(text);
            Console.WriteLine("-----");

            Fifth(text);
        }

        private static void One(string text)
        {
            var spaces = text.Count(n => n == ' ');
            Console.WriteLine($"スペースの数: {spaces}");
        }

        private static void Two(string text)
        {
            var target = text.Replace("big", "small");
            Console.WriteLine(target);
        }

        private static void Three(string text)
        {
            var count = text.Split(' ').Length;
            Console.WriteLine(count);
        }

        private static void Four(string text)
        {
            var count = text.Split(' ')
                            .Where(n => n.Length <= 4);
            foreach (var len in count)
            {
                Console.WriteLine(len);
            }
            
        }

        private static void Fifth(string text)
        {
            var array = text.Split(' ')
                            .ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var clone = sb.ToString();
                Console.WriteLine(clone);
            }
                            
        }
    }

}
 