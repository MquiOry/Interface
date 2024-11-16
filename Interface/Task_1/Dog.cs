using System;

namespace Solution
{
    class Dog : IAnimal
    {
        public void Speak() => Console.WriteLine("Гав-Гав");

        public void Move() => Console.WriteLine("Бегает");
    }
}
