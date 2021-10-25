namespace lab5.Controllers
{
    struct ShipEnumController
    {
        public static Vehicles.Ship GetShip(Ships shipType)
        {
            switch (shipType)
            {
                case Ships.Boat:
                {
                    return new Vehicles.Boat(null, null, 0);
                }
                case Ships.Corvette:
                {
                    return new Vehicles.Corvette(null, null, 0);
                }
                case Ships.Sailboat:
                {
                    return new Vehicles.Sailboat(null, null, 0);
                }
                case Ships.Steamer:
                {
                   return new Vehicles.Steamer(null, null, 0);
                }
                default:
                {
                        return null;
                }
            }
        }
    }
}