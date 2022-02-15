using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    [Serializable]
    class Ship: Vehicle
    {
        public string Captain { get; set; }
        public Ship(string name, string captain) : base(name)
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
