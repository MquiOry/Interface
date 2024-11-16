using System;


namespace Solution
{
    class Bird : IAnimal
    {
        public void Speak() => Console.WriteLine("Чирик-чирик");

        public void Move() => Console.WriteLine("Летает");

    }
}
