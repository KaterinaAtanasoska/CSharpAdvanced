using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass04
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
        
        public static bool Validate(Dog dog)
        {
            if (dog.Name == null || dog.Color == null)
            {
                return false;
            }
            else if (dog.Id < 0)
            {
                return false;
            }
            else if (dog.Name.Length < 2)
            {
                return false;
            }
            return true;
        }
    }
}
