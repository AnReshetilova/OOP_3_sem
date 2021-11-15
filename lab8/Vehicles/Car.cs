using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Car : Vehicle, ICarRequirements
    {
        public int WheelsAmount { get; set; }
        public override void Move()
        {
            Console.WriteLine("Riding");
        }

        void ICarRequirements.Move()
        {
            Console.WriteLine("Moving");
        }

        public Car(string name) : base(name) { }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
