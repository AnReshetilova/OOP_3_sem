using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();

            //(int, int, int, char) tuple;
            //int[] arr = { 3, 4, 5, 6 };
            //string str = "cat dog fox";
            //tuple = taskTupleFunction(arr, str);
            //Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3 + " " + tuple.Item4);

            checkedFunction();
            uncheckedFunction();
        }
        private static void Task1()
        {
            bool boolValue = default(bool);
            byte byteValue = default(byte);
            sbyte sbyteValue = default(sbyte);
            char charValue = default(char);
            string stringValue = default(string);
            decimal decimalValue = default(decimal);
            double doubleValue = default(double);
            float floatValue = default(float);
            int intValue = default(int);
            uint uintValue = default(uint);
            short shortValue = default(short);
            ushort ushortValue = default(ushort);
            long longValue = default(long);
            ulong ulongValue = default(ulong);
            object objectValue = default(object);

            boolValue = Boolean.Parse(Console.ReadLine());
            byteValue = Byte.Parse(Console.ReadLine());
            sbyteValue = SByte.Parse(Console.ReadLine());
            charValue = Char.Parse(Console.ReadLine());
            stringValue = Console.ReadLine();
            decimalValue = Decimal.Parse(Console.ReadLine());
            doubleValue = Double.Parse(Console.ReadLine());
            floatValue = Single.Parse(Console.ReadLine());
            intValue = Int32.Parse(Console.ReadLine());
            uintValue = UInt32.Parse(Console.ReadLine());
            shortValue = Int16.Parse(Console.ReadLine());
            ushortValue = UInt16.Parse(Console.ReadLine());
            longValue = Int64.Parse(Console.ReadLine());
            ulongValue = UInt64.Parse(Console.ReadLine());
            objectValue = Console.ReadLine();

            Console.WriteLine(boolValue);
            Console.WriteLine(byteValue);
            Console.WriteLine(sbyteValue);
            Console.WriteLine(charValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(decimalValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(intValue);
            Console.WriteLine(uintValue);
            Console.WriteLine(shortValue);
            Console.WriteLine(ushortValue);
            Console.WriteLine(longValue);
            Console.WriteLine(ulongValue);
            Console.WriteLine(objectValue);

            shortValue = byteValue;
            intValue = shortValue;
            longValue = intValue;
            floatValue = longValue;
            doubleValue = floatValue;

            intValue = (int)doubleValue;
            intValue = (int)floatValue;
            intValue = (int)decimalValue;
            longValue = (long)decimalValue;
            longValue = (long)doubleValue;

            //boxing
            objectValue = intValue;
            //unboxing
            longValue = (long)(int)objectValue;

            var implicitlyTyped = 42;
            Console.WriteLine(implicitlyTyped.GetType());

            int? maybeNull = 42;
            if (maybeNull is int)
            {
                Console.WriteLine(maybeNull);
            }
            else
            {
                Console.WriteLine("null");
            }

            var implicitlyTypedError = 1;
            //implicitlyTypedError = true;
        }

        private static void Task2()
        {
            string catStr = "cat";
            string dogStr = "dog";
            string foxstr = "fox";

            switch (string.Compare(catStr, dogStr))
            {
                case 1:
                    {
                        Console.WriteLine("dog greater");
                        break;
                    }
                case -1:
                    {
                        Console.WriteLine("cat greater");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("the same");
                        break;
                    }
            }

            string catdogfoxStr = string.Concat(catStr, dogStr, foxstr);
            string result;
            Console.WriteLine(catdogfoxStr);

            Console.WriteLine("------------Copy-------------");
            result = string.Copy(foxstr);
            Console.WriteLine(result);

            Console.WriteLine("------------Substring-------------");
            result = catdogfoxStr.Substring(0, catdogfoxStr.Length - 3);
            Console.WriteLine(result);

            Console.WriteLine("------------Split-------------");
            result = "cat dog fox";
            string[] resultArr = result.Split(' ');
            foreach (string str in resultArr)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------Insert-------------");
            string substr = "elephant";
            result = catdogfoxStr;
            result = result.Insert(3, substr);
            Console.WriteLine(result);

            Console.WriteLine("------------Remove-------------");
            result = result.Remove(3, 8);
            Console.WriteLine(result);

            Console.WriteLine("------------IsNullOrEmpty-------------");
            string[] strs = { null, "", "cat" };
            foreach (string s in strs)
            {
                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("null or empty");
                }
                else
                {
                    Console.WriteLine($"{s} isn't null or empty");
                }
            }

            Console.WriteLine("------------StringBuilder-------------");
            StringBuilder sb = new StringBuilder("cat dog fox");
            sb.Remove(4, 4);
            Console.WriteLine(sb);
            sb.Append(" dog");
            Console.WriteLine(sb);
            sb.Insert(0, "elephant ");
            Console.WriteLine(sb);
        }

        private static void Task3()
        {
            Console.WriteLine("------------multiDimensionalArray-------------");
            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(multiDimensionalArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            string[] strArr = { "cat", "dog", "fox" };

            foreach (string s in strArr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine(strArr.Length);

            int position = -1;

            while (position < 0 || position >= strArr.Length)
            {
                Console.WriteLine("Enter position");
                position = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter element");

            string element = Console.ReadLine();
            strArr[position] = element;

            foreach (string s in strArr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();


            Console.WriteLine("------------jaggedArray -------------");
            float[][] jArr = new float[3][];
            jArr[0] = new float[2];
            jArr[1] = new float[3];
            jArr[2] = new float[4];

            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    jArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    Console.Write(jArr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            var arr = new string[] { "smth", "smth" };
            var sstr = "smth";
        }

        private static void Task4()
        {
            (int, string, char, string, ulong) tupl = (42, "str", 'c', "str2", 4242);
            Console.WriteLine($"int - {tupl.Item1} " +
                $"string - {tupl.Item2} " +
                $"char - {tupl.Item3} " +
                $"string - {tupl.Item4} " +
                $"ulong - {tupl.Item5}");
            Console.WriteLine($"char - {tupl.Item3} string - {tupl.Item4}");

            (var a, var b) = (12, "42");
            Console.WriteLine(a + " " + b);

            int intval = tupl.Item1;
            string strval = tupl.Item2;

            var (_, pop, _) = ("new york", 8175133, 468.48);
            Console.WriteLine(pop);
        }

        private static (int, int, int, char) taskTupleFunction(int[] arr, string str)
        {
            var tuple = (arr.Max(), arr.Min(), arr.Sum(), str[0]);
            return tuple;
        }

        private static void checkedFunction()
        {
            int z = 0;
            int maxIntValue = 2147483647;
            try
            {
                z = checked(maxIntValue + 10);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            Console.WriteLine(z);
        }

        private static void uncheckedFunction()
        {
            int z = 0;
            int maxIntValue = 2147483647;
            try
            {
                z = unchecked(maxIntValue + 10);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            Console.WriteLine(z);
        }
    }
}
