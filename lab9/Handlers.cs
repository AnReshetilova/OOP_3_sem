using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    delegate void OperationSqueezing(ref int size);
    delegate void OperationMoving(ref string coord);
    class ParamHandler
    {
        public virtual void Message()
        {
            Console.WriteLine("the same place or position as the other window!");
        }
    }
    class PositionHandler : ParamHandler
    {
        public override void Message()
        {
            Console.WriteLine("the same position as the other window!");
        }
    }

    class PlaceHandler : ParamHandler
    {
        public override void Message()
        {
            Console.WriteLine("the same place as the other window!");
        }
    }
}

   
