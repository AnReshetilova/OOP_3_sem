using System;
using lab8.Controllers;
using lab5.People;
using lab5.Vehicles;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Captain captain1 = new Captain("Steve", 50);

            Ship ship1 = new Ship("NewShip", captain1);
            Corvette corvette1 = new Corvette("NewCorvette", captain1, 15);

            Collection<Ship> port = new Collection<Ship>();
            port.AddElement(ship1);
            port.AddElement(corvette1);

            port.GetElements();

            Collection<int> collectionInt = new Collection<int>();
            collectionInt.AddElement(3);
            collectionInt.AddElement(4);
            collectionInt.AddElement(9);

            collectionInt.GetElements();

            Collection<double> collectionDouble = new Collection<double>();
            collectionDouble.AddElement(3.1);
            collectionDouble.AddElement(4.8);
            collectionDouble.AddElement(9.2);

            collectionDouble.GetElements();

            port.ToFile();
            Collection<string> str = port.FromFile();

            str.GetElements();
        }
    }
}
