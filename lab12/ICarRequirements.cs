using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    interface ICarRequirements
    {
        int WheelsAmount { get; set; }
        void Move(double speed);
    }
}
