using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Controllers
{
    partial class Port
    {
        public int GetDispalcement()
        {
            int displacement = 0;
            Vehicles.Sailboat sailboat;
            for (int i = 0; i < Length; i++)
            {
                if ((sailboat = GetElementByIndex(i) as Vehicles.Sailboat) != null)
                {
                    displacement += sailboat.Displacement;
                }
            }

            return displacement;
        }

        public int GetSeats()
        {
            int seats = 0;
            int steamerCounter = 0;
            Vehicles.Steamer streamer;
            for (int i = 0; i < Length; i++)
            {
                if ((streamer = GetElementByIndex(i) as Vehicles.Steamer) != null)
                {
                    seats += streamer.Seats;
                    steamerCounter++;
                }
            }

            return seats/steamerCounter;
        }

        public Port GetShipsWithYoungCaptains()
        {
            Port shipsWithYoungCaptains = new Port();
            for (int i = 0; i < Length; i++)
            {
                if (GetElementByIndex(i).Captain.Age < 35)
                {
                    shipsWithYoungCaptains.AddElement(GetElementByIndex(i));
                }
            }

            return shipsWithYoungCaptains;
        }
    }
}
