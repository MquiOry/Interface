using System;


namespace Solution
{
    class Car : IVehicle
    {
        public int MaxSpeed { get; set; }   
        public int GetMaxSpeed()
        {
            return MaxSpeed = 200;
        }

        public void Drive() => Console.WriteLine($"Максимальная скорость: {MaxSpeed}");
    }
}
