using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    [Serializable]
    class Car : ICarRequirements
    {
        public int WheelsAmount { get; set; }
        public void Move()
        {
            Console.WriteLine("Riding");
        }

        void ICarRequirements.Move()
        {
            Console.WriteLine("Moving");
        }

        public Car(string name){ }
        public Car() { }
    }
}
