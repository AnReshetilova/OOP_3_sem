using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Sailboat : Ship
    {
        public int Displacement { get; set; }
        public Sailboat(string name, People.Captain captain, int displacement) : base(name, captain)
        {
            Displacement = displacement;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
