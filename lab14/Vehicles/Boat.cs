using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    class Boat : Ship
    {
        int CountOfPaddles { get; set; }
        public Boat(string name, string captain, int countOfPaddles) : base(name, captain)
        {
            CountOfPaddles = countOfPaddles;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
