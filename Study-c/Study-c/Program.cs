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
            var collection = new YearMonth[]
            {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            One(collection);
            Console.WriteLine("-----");

            Two(collection);
            Console.WriteLine("-----");

            Three(collection);
            Console.WriteLine("-----");

        }

        private static void One(YearMonth[] collection)
        {
            foreach (var n in collection)
            {
                Console.WriteLine(n);
            }
        }

        static YearMonth First21(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        private static void Two(YearMonth[] collection)
        {
            var yearmonth = First21(collection);
            if (yearmonth == null)
                Console.WriteLine("21世紀はありません");
            else
                Console.WriteLine(yearmonth);
        }

        private static void Three(YearMonth[] collection)
        {
            var array = collection.Select(n => n.AddOneMonth())
                                  .ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }

        }
    }

    class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public bool Is21Century
        {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }
        }

        public YearMonth AddOneMonth()
        {
            if (Month == 12)
            {
                return new YearMonth(this.Year + 1, 1);
            }
            else
            {
                return new YearMonth(this.Year, this.Month + 1);
            }
        }

        public override string ToString()
        {
            return $"{Year}年 {Month}月";
        }

    }
}
