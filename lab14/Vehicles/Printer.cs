﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14.Vehicles
{
    class Printer
    {
        public void IAmPrinting(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.ToString());
        }
    }
}
