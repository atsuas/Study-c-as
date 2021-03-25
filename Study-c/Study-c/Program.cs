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
        }

        private static void One(string text)
        {
            var spaces = text.Count(n => n == ' ');
            Console.WriteLine($"スペースの数: {spaces}");
        }
    }

}
 