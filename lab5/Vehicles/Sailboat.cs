using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Sailboat : Ship
    {
        int CountOfSail { get; set; }
        public Sailboat(string name, string captainName, int countOfSail) : base(name, captainName)
        {
            CountOfSail = countOfSail;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
