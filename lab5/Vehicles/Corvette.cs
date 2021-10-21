using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Corvette: Ship
    {
        int CountOfGuns { get; set; }
        public Corvette(string name, string captainName, int countOfGuns) : base(name, captainName)
        {
            CountOfGuns = countOfGuns;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
