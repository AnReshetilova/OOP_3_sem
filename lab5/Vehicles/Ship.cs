using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Ship: Vehicle
    {
        public People.Captain Captain { get; set; }
        public Ship(string name, People.Captain captain) : base(name)
        {
            Captain = captain;
        }
        public override void Move()
        {
            Console.WriteLine("Sailing");
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
