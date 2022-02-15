using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    class Sailboat : Ship
    {
        public int Displacement { get; set; }
        public Sailboat(string name, string captain, int displacement) : base(name, captain)
        {
            Displacement = displacement;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
