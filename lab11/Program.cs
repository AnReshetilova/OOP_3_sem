using System;
using System.Linq;
using System.Collections.Generic;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            string[] months = { "June", "July", "May", "December", "January", "February", "March", "April", "August", "September", "October", "November" };

            var monthWithCurrentLength = months.Where(m => m.Length == n);
            foreach(string m in monthWithCurrentLength)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            var summerAndWinterMonth = months.Where(m => m == "June" || m == "July" || m == "August" || m == "January" || m == "December" || m == "February");
            foreach(string m in summerAndWinterMonth)
            { 
                Console.WriteLine(m); 
            }
            Console.WriteLine();

            var alphabet = months.OrderBy(m => m);
            foreach (string m in alphabet)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            int currentRules = months.Count(m => m.Contains("u") && m.Length >= 4);
            Console.WriteLine(currentRules);

            List<Date> date = new List<Date>();
            date.Add(new Date(11, 12, 2001));
            date.Add(new Date(13, 11, 2002));
            date.Add(new Date(14, 10, 2003));
            date.Add(new Date(15, 9, 2004));
            date.Add(new Date(16, 9, 2005));
            date.Add(new Date(16, 8, 2006));
            date.Add(new Date(18, 7, 2007));
            date.Add(new Date(19, 6, 2008));
            date.Add(new Date(20, 5, 2009));
            date.Add(new Date(21, 4, 2001));
            /*список дат для заданного года;
                список дат, которые имеют заданный месяц
                количество дат в определённом диапазоне
                максимальную дату
                Первую дату для заданного дня
           Упорядоченный список дат (хронологически)*/

            int year = 2001;
            var datesWithCurrentYear = date.Where(d => d.Year == year);
            foreach (Date d in datesWithCurrentYear)
            {
                d.PrintDateShortFormat();
            }
            Console.WriteLine();

            int month = 9;
            var datesWithCurrentMonth = date.Where(d => d.Month == month);
            foreach (Date d in datesWithCurrentMonth)
            {
                d.PrintDateShortFormat();
            }
            Console.WriteLine();

            int minDay = 10;
            int maxday = 15;
            var datesWithCurrentDays = date.Where(d => d.Day >= minDay && d.Day <= maxday);
            foreach (Date d in datesWithCurrentDays)
            {
                d.PrintDateShortFormat();
            }
            Console.WriteLine();

            Date MaxDate = (date.Where(d => (d.Month + d.Year + d.Day) == date.Max(m => (m.Month + m.Year + m.Day)))).First();
            MaxDate.PrintDateShortFormat();
            Console.WriteLine();

            int day = 16;
            Date dateWithCurrentDay = date.Where(d => d.Day == day).First();
            dateWithCurrentDay.PrintDateShortFormat();
            Console.WriteLine();

            var orderedDates = date.OrderBy(y => y.Year).ThenBy(m => m.Month).ThenBy(d => d.Day);
            foreach(Date d in orderedDates)
            {
                d.PrintDateShortFormat();
            }
            Console.WriteLine();

            //4 даты с годом больше 2007, объедененные с теми, где день < 15 с исключением 2009 года. Отсортированные по году
            var myDates = (date.Where(y => y.Year > 2007).Take(4).Union(date.Where(d => d.Day < 15)).Except((date.Where(d => d.Year == 2008))).OrderBy(y => y.Year));
            foreach (Date d in myDates)
            {
                d.PrintDateShortFormat();
            }
            Console.WriteLine();

            var joinedDates = from o in orderedDates
                              join m in myDates on o.Year equals m.Year
                              select m;
            foreach (Date d in joinedDates)
            {
                d.PrintDateShortFormat();
            }
        }
    }
}
