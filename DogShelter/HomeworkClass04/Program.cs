using System;

namespace HomeworkClass04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog() { Id = 1, Name = "Dora", Color = "Black" };
            Dog dog2 = new Dog() { Id = 2, Name = "Charlie", Color = "Brown" };
            Dog dog3 = new Dog() { Id = 3, Name = "Max", Color = "Black" };

            if (Dog.Validate(dog1) == true)
            {
                DogShelter.dogs.Add(dog1);
            }

            if (Dog.Validate(dog2) == true)
            {
                DogShelter.dogs.Add(dog2);
            }

            if (Dog.Validate(dog3) == true)
            {
                DogShelter.dogs.Add(dog3);
            }

            DogShelter.PrintAll();
                  

            Console.ReadLine();
        }
    }
}
