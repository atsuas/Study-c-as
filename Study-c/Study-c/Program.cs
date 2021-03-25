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
            var yearMonth = new YearMonth[]
            {
                new YearMonth(1990, 8),
                new YearMonth(1999, 7),
                new YearMonth(2000, 3),
                new YearMonth(2020, 4),
                new YearMonth(2035, 2),
            };

            One(yearMonth);
            Console.WriteLine("-----");

            Two(yearMonth);
            Console.WriteLine("-----");

            Three(yearMonth);
            Console.WriteLine("-----");


            static void One(YearMonth[] ymCollection)
            {
                foreach (var ym in ymCollection)
                {
                    Console.WriteLine(ym);
                }
            }

            static YearMonth First(YearMonth[] yms)
            {
                foreach (var ym in yms)
                {
                    if (ym.Is21Century)
                        return ym;
                }
                return null;
            }

            static void Two(YearMonth[] yms)
            {
                var yearmonth = First(yms);
                if (yearmonth == null)
                {
                    Console.WriteLine("21世紀は存在しません");
                }
                else
                {
                    Console.WriteLine(yearmonth);
                }
            }

            static void Three(YearMonth[] yms)
            {
                var array = yms.Select(n => n.AddOneMonth())
                               .ToArray();
                foreach (var ym in array)
                {
                    Console.WriteLine(ym);
                }
            }

        }

    }

    public class YearMonth
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
            return $"{Year}年{Month}月";
        }

    }
}
 