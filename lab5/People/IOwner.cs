using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.People
{
    interface IOwner
    {
        string Name { get; set; }
        int Age { get; set; }
        string Profession { get; set; }
        void BuySomething();
    }
}
