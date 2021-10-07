using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(3, 12, 2015);
            Date date2 = new Date(3);
            Date date3 = new Date();
            Date date4 = new Date(3);
            Date date5 = new Date(29);

            // date3 information
            Console.WriteLine($"{date3.MinDate} {date3.Id} " + date3.ToString());
            
            date1.PrintDateLongFormat();
            date2.PrintDateShortFormat();
            Date.GetClassInfo();

            //methods fith ref and out
            date1.PrintDateShortFormat();
            int day = 0;
            int month = 0;
            int year = 0;
            date1.GenerateDayMonth(ref day, ref month);
            date1.GenerateYear(out year);
            date1.Day = day;
            date1.Month = month;
            date1.Year = year;
            date1.PrintDateShortFormat();

            //is equals?
            Console.WriteLine(date1.Equals(date2));
            date1.Equals(year);

            //getHashCode
            date1.GetHashCode();

            //getType
            Console.WriteLine(date1.GetType());

            Date[] dateArr = { date1, date2, date3, date3, date4, date5 };
            Console.WriteLine("with the same year");
            for (int i = 0; i < 5; i++)
            {
                if(dateArr[i].Year == date2.Year)
                {
                    dateArr[i].PrintDateShortFormat();
                }
            }

            Console.WriteLine("with the same date");
            for (int i = 0; i < 5; i++)
            {
                if (dateArr[i].Day == date2.Day)
                {
                    dateArr[i].PrintDateShortFormat();
                }
            }

           
            var anDate = new Date(5, 11, 2000);
            anDate.PrintDateShortFormat();
        }
    }
}
