using System;

namespace Solution
{
    class Bike : IVehicle
    {
        public int MaxSpeed { get; set; }   

        public int GetMaxSpeed()
        {
            return MaxSpeed = 100;
        }

        public void Drive() => Console.WriteLine($"Едет со скоростью: {MaxSpeed}");
    }
}
