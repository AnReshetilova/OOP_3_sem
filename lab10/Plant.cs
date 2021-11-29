using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Plant
    {
        public string Name { get; set; }
        public Plant(string name)
        {
            Name = name;
        }
        public void ToGrow()
        {
            Console.WriteLine("Is growing...");
        }
    }
}
