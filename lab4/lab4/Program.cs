using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(-10);
            Vector vector2 = new Vector();

            vector.AddElement(14);
            vector.AddElement(-320);
            vector.AddElement(6);
            vector.GetVector();

            vector2.AddElement(-1000);
            vector2.AddElement(-11);

            Console.WriteLine(vector.GetElementByIndex(2));
            Console.WriteLine(vector.Length);
            Console.WriteLine(vector.GetElementByIndex(14));

            vector = vector + vector2;
            vector.GetVector();

            if (vector > vector2)
            {
                Console.WriteLine("vector1 > vector2");
            }

            Console.WriteLine($"id: {Vector.Owner.id} name: {Vector.Owner.name} organisation: {Vector.Owner.organisation}");
            Console.WriteLine($"Creation date: {Vector.Date.creationDate}");

            //they made me...
            vector2 = vector2 == vector;
            vector2.GetVector();

            vector2.RemoveElementByIndex(1);
            vector2.GetVector();

            Console.WriteLine(vector2.Sum());

            Console.WriteLine(vector2.Difference());

            Console.WriteLine(vector2.GetLength());

            vector2.RemovePositive();
            vector2.GetVector();

            string str = "smthsmthsmth";
            Console.WriteLine(str.CutString(4));
        }
    }
}
