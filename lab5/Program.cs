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
            #region lab5
            //Vehicles.Vehicle car = new Vehicles.Car("BMW");
            //car.Move();
            //Vehicles.ICarRequirements car2 = new Vehicles.Car("BMW");
            //car2.Move();

            //People.Captain cap1 = new People.Captain("Sven", 60);
            //Vehicles.Corvette corvette = new Vehicles.Corvette("Linda", cap1, 40);
            //cap1.ToString();
            //Vehicles.Ship ship = new Vehicles.Ship("newShip", new People.Captain("Steve", 32));

            //if (corvette is Vehicles.Ship)
            //{
            //    Console.WriteLine("corvette is a ship");
            //}

            //if (ship as Vehicles.Corvette == null)
            //{
            //    Console.WriteLine("ship is not a corvette");
            //}

            //Console.WriteLine(corvette.ToString());
            //Console.WriteLine(ship.ToString());
            //Console.WriteLine(car.ToString());

            //Vehicles.Vehicle[] vehicles = { ship, car, corvette };
            //Vehicles.Printer printer = new Vehicles.Printer();
            //foreach(var n in vehicles)
            //{
            //    printer.IAmPrinting(n);
            //}
            #endregion
            People.Captain cap1 = new People.Captain("Sven", 60);

            Vehicles.Boat boat = (Vehicles.Boat)Controllers.ShipEnumController.GetShip(Controllers.Ships.Boat);
            boat.Name = "Vendetta";
            boat.Captain = new People.Captain("Steve", 25);

            Vehicles.Sailboat sailboat = new Vehicles.Sailboat("sailBoat", cap1, 20);
            Vehicles.Sailboat sailboat2 = new Vehicles.Sailboat("sailBoat2", cap1, 20);

            Vehicles.Steamer steamer = new Vehicles.Steamer("steamer1", new People.Captain("Anton", 20), 60);
            Vehicles.Steamer steamer2 = new Vehicles.Steamer("steamer2", new People.Captain("German", 45), 34);

            Controllers.Port port = new Controllers.Port(boat);
            port.AddElement(sailboat);
            port.AddElement(sailboat2);
            port.AddElement(steamer);
            port.AddElement(steamer2);

            port.GetShips();
            Console.WriteLine(port.GetSeats());
            Console.WriteLine(port.GetDispalcement());

            Controllers.Port port1 = port.GetShipsWithYoungCaptains();
            port1.GetShips();
        }
    }
}
