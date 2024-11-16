using System;

namespace Solution
{
    class UniversityStudent : IStudent
    {
        public string Name { get; set; }

        public UniversityStudent(string name)
        {
            Name = name;
        }

        public void Work() => Console.WriteLine($"{Name} сейчас на работе");

        public void Relax() => Console.WriteLine($"{Name} сейчас апает радика");

        public void Study() => Console.WriteLine($"{Name} сейчас учится");

    }
}
