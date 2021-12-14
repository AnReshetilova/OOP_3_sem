using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Corvette corvette = new Corvette("Vendetta", "Sven", 16);
            using (StreamWriter sw = new StreamWriter(@"text.txt", false, Encoding.Default))
            {
                sw.WriteLine(Reflector.GetAssemblyName(car.GetType().ToString()));

                sw.WriteLine();
                foreach (var item in Reflector.GetPublicMethods(typeof(Corvette).ToString()))
                {
                    sw.WriteLine(item);
                }

                sw.WriteLine();
                sw.WriteLine(Reflector.IsAnyPublicConstructors(typeof(Car).ToString()));
                sw.WriteLine(Reflector.IsAnyPublicConstructors(typeof(Reflector).ToString()));

                sw.WriteLine();
                foreach (var item in Reflector.GetFieldsAndProp(typeof(Corvette).ToString()))
                {
                    sw.WriteLine(item);
                }

                sw.WriteLine();
                foreach (var item in Reflector.GetInterfaces(typeof(Car).ToString()))
                {
                    sw.WriteLine(item);
                }

                sw.WriteLine();

                Reflector.Invoke(typeof(Car).ToString(), "GetCarName");
                sw.WriteLine(Reflector.Create(typeof(Car).ToString()).ToString());
            }
        }
    }
}
