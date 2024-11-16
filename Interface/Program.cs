using System; 

namespace Solution
{
    class Program
    {
        // Task_2
        static void CallMethods(List<IVehicle> list)
        {
            foreach (var value in list)
            {
                value.GetMaxSpeed();
                value.Drive();
            }
        }

        static void Main()
        {
            Bird bird = new Bird();
            Dog dog = new Dog();

            bird.Speak();
            bird.Move();

            dog.Speak();
            dog.Move();

            Console.WriteLine("------------------------");
            //--------------------------------------------

            Car car1 = new Car();
            Bike bike1 = new Bike();
            Car car2 = new Car();
            Bike bike2 = new Bike();

            List<IVehicle> collection = new List<IVehicle>();
            collection.Add(car1);
            collection.Add(car2);
            collection.Add(bike1);
            collection.Add(bike2);


            CallMethods(collection);

            Console.WriteLine("------------------------");
            //--------------------------------------------

            Circle circle = new Circle(4.2);
            Rectangle rectangle = new Rectangle(2.3, 3.1);
            Circle circle2 = new Circle(6);
            Rectangle rectangle2 = new Rectangle(10, 9);


            IShape[] array = new IShape[] {circle, rectangle, circle2, rectangle2};

            foreach (var value in array)
                Console.WriteLine(value.GetArea());

            Console.WriteLine("------------------------");
            //--------------------------------------------

            UniversityStudent student = new UniversityStudent("Бобби");

            student.Study();
            student.Work();
            student.Relax();

            Console.WriteLine("------------------------");
            //--------------------------------------------

            Console.WriteLine("Выберите объект, который хотите создать\n" +
                              "1. Собака \n2. Птица");

            IAnimal animal = null;

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    {
                        animal = new Dog();
                        break;
                    }
                case 2:
                    {
                        animal = new Bird();
                        break;
                    }
            }

            if(animal != null)
            {
                animal.Speak();
                animal.Move();
            }

            Console.WriteLine("------------------------");
            //--------------------------------------------

            MultifunctionDevice scanner = new MultifunctionDevice();
            MultifunctionDevice printer = new MultifunctionDevice();

            Console.WriteLine(scanner.Scan()); 
            printer.Print("Ваше сообщение :3");
        }
    }
}