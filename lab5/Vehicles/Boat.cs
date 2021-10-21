using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Boat : Ship
    {
        int CountOfPaddles { get; set; }
        public Boat(string name, string captainName, int countOfPaddles) : base(name, captainName)
        {
            CountOfPaddles = countOfPaddles;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
