using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Steamer: Ship
    {
        int CountOfPipes { get; set; }
        public Steamer(string name, string captainName, int countOfPipes) :base (name, captainName)
        {
            CountOfPipes = countOfPipes;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
