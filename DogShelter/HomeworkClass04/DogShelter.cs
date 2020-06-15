using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass04
{
    public static class DogShelter
    {
        public static List<Dog> dogs = new List<Dog>();
        public static void PrintAll()
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Id: {dog.Id} | Name: {dog.Name} | Color: {dog.Color}");
            }
        }
    }
}
