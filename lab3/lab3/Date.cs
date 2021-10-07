using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    partial class Date
    {
        private int day;
        private int month;
        private int year;
        private readonly int id;
        private static DateTime todayDate;
        private static int count;
        private const string minDate = "01.01.0001";

        #region Properties
        public int Day
        {
            set
            {
                if (value < 1 || value > 31)
                {
                    Console.WriteLine("Incorrect day");
                }
                else
                {
                    day = value;
                }
            }

            get
            {
                return day;
            }
        }

        public int Month
        {
            set
            {
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("Incorrect month");
                }
                else
                {
                    month = value;
                }
            }

            get
            {
                return month;
            }
        }

        public int Year
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Incorrect year");
                }
                else
                {
                    year = value;
                }
            }

            get
            {
                return year;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public DateTime TodayDate
        {
            get
            {
                return todayDate;
            }
            private set
            {
                todayDate = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public string MinDate
        {
            get
            {
                return minDate;
            }
        }
        #endregion

        #region Constructors
        public Date()
        {
            day = 12;
            month = 12;
            year = 2012;
            count++;
            id = count * 100000000 + year * 10000 + month * 100 + day;
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
            count++;
            id = count * 100000000 + year * 10000 + month * 100 + day; 
        }

        public Date(int day, int month = 12)
        {
            Day = day;
            Month = month;
            Year = 2012;
            count++;
            id = count * 100000000 + year * 10000 + month * 100 + day;
        }

#pragma warning disable S3963 // "static" fields should be initialized inline
        static Date()
        {
            Console.WriteLine("the first date created");
            todayDate = DateTime.Now;
            count = 0;
        }
#pragma warning restore S3963 // "static" fields should be initialized inline

        private Date(int Count)
        {
            count = Count;
        }
        #endregion

        #region Methods
        public void GenerateDayMonth(ref int day, ref int month)
        {
            Random rnd = new Random();
            day = rnd.Next(32);
            month = rnd.Next(13);
        }

        public void GenerateYear(out int year)
        {
            Random rnd = new Random();
            year = rnd.Next(2022);
        }

        public void PrintDateLongFormat()
        {
            string[] longMonth = {"января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа",
            "сентября", "октября", "ноября", "декабря"};

            Console.WriteLine($"{day} {longMonth[month - 1]} {year} года");
        }

        public void PrintDateShortFormat()
        {
            Console.WriteLine($"{day}/{month}/{year}");
        }

        public static void GetClassInfo()
        {
            Console.WriteLine($"today - {todayDate}" +
                $" counter - {count}");
        }
        #endregion
    }
}
