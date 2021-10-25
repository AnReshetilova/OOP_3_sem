using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    class Steamer: Ship
    {
        public int Seats { get; set; }
        public Steamer(string name, People.Captain captain, int seats) :base (name, captain)
        {
            Seats = seats;
        }
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.Name}";
        }
    }
}
