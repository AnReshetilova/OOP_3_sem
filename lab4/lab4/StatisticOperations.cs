using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class StatisticOperations
    {
        public static int Sum(this Vector v1)
        {
            int sum = 0;
            for(int i = 0; i < v1.Length; i++)
            {
                sum += v1.GetElementByIndex(i);
            }

            return sum;
        }

        public static int Difference(this Vector v)
        {
            int min = int.MaxValue;
            int max = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v.GetElementByIndex(i) > max)
                {
                    max = v.GetElementByIndex(i);
                }
                
                if (v.GetElementByIndex(i) < min)
                {
                    min = v.GetElementByIndex(i);
                }
            }

            return max - min;
        }

        public static int GetLength(this Vector v)
        {
            return v.Length;
        }

        public static string CutString(this string str, int count)
        {
            return str.Substring(count);
        }

        public static Vector RemovePositive(this Vector v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v.GetElementByIndex(i) > 0)
                {
                    v.RemoveElementByIndex(i);
                }    
            }

            return v;
        }
    }
}
