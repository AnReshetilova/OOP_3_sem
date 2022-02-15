using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    [Serializable]
    public abstract class Vehicle
    {
        public string Name { get; set; }
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
