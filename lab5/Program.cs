using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles.Vehicle car = new Vehicles.Car("BMW");
            car.Move();
            Vehicles.ICarRequirements car2 = new Vehicles.Car("BMW");
            car2.Move();

            People.Captain cap1 = new People.Captain("Sven", 60);
            Vehicles.Corvette corvette = new Vehicles.Corvette("Linda", cap1.Name, 40);
            cap1.ToString();
            Vehicles.Ship ship = new Vehicles.Ship("newShip", "Steve");
            
            if (corvette is Vehicles.Ship)
            {
                Console.WriteLine("corvette is a ship");
            }

            if (ship as Vehicles.Corvette == null)
            {
                Console.WriteLine("ship is not a corvette");
            }

            Console.WriteLine(corvette.ToString());
            Console.WriteLine(ship.ToString());
            Console.WriteLine(car.ToString());

            Vehicles.Vehicle[] vehicles = { ship, car, corvette };
            Vehicles.Printer printer = new Vehicles.Printer();
            foreach(var n in vehicles)
            {
                printer.IAmPrinting(n);
            }
        }
    }
}
