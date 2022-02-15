using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    [Serializable]
    public class Corvette
    {
        int CountOfGuns { get; set; }
        public Corvette() { }
        public Corvette(string name, string captain, int countOfGuns)
        {
            CountOfGuns = countOfGuns;
        }
    }
}
