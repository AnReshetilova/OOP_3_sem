using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Vehicles
{
    public abstract class Vehicle
    {
        protected string Name { get; set; }
        public Vehicle(string name)
        {
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("Moving");
        }
    }
}
