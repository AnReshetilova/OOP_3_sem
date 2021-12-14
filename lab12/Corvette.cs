using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Corvette
    {
        public int CountOfGuns { get; set; }

        public int justFiled;
        public Corvette(string name, string captain, int countOfGuns)
        {
            CountOfGuns = countOfGuns;
        }
        public override string ToString()
        {
            return $"There is a {GetType()}";
        }

        void NotPublicMethod() { }
    }
}
