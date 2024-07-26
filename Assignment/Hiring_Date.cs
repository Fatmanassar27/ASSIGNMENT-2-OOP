using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Hiring_Date
    {
        public int Day   { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Hiring_Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public Hiring_Date(Hiring_Date hiring_Date)
        {
            Day = hiring_Date.Day ;
            Month = hiring_Date.Month ;
            Year = hiring_Date.Year ;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public static Hiring_Date CreateHiringDate ()
        {
            string? input;
            int day;
            int month;
            int year;

            do
            {
                Console.Write("Enter Day of Hiring Date : ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out day));

            do
            {
                Console.Write("Enter Month of Hiring Date : ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out month));

            do
            {
                Console.Write("Enter Year of Hiring Date : ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out year));

            return new Hiring_Date(day, month, year);
        }

        public static bool CompareHiringDate (Hiring_Date right , Hiring_Date left )
        {
            if (right.Year > left.Year)
            {
                return true;
            }
            else if (right.Year < left.Year)
            {
                return false;
            }

            else if (right.Month > left.Month)
            {
                return true;
            }
            else if (right.Month < left.Month)
            {
                return false;
            }

            else if (right.Day > left.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
