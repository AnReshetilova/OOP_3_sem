using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Ship: Vehicle
    {
        string CaptainName { get; set; }
        public Ship(string name, string captainName) : base(name)
        {
            CaptainName = captainName;
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
