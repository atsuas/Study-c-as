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
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            if (string.Compare(a, b, ignoreCase:true) == 0)
            {
                Console.WriteLine("同じです");
            }
            else
            {
                Console.WriteLine("違います");
            }

        }

    }

}
 