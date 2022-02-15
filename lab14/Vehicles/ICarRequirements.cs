using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    interface ICarRequirements
    {
        int WheelsAmount { get; set; }
        void Move();
    }
}
