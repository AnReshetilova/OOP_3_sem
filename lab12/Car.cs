using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Car: ICarRequirements
    {
        public int WheelsAmount { get; set; }
        public void Move(double speed)
        {
            Console.WriteLine("Riding");
        }

        public string ToString()
        {
            return $"There is a {GetType()}";
        }

        public void GetCarName(string name)
        {
            Console.WriteLine("car name - " + name);
        }
    }
}
