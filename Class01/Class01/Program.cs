﻿using System;
using System.Collections.Generic;

namespace Class01
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            Console.WriteLine("Enter name:");
            
            
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "x" || text == "X")
                {
                    break;
                }
                nameList.Add(text);
            }

            int count = 0;
            Console.WriteLine("Search name:");
            string searchInput = Console.ReadLine();
            Console.WriteLine("Result:");
            foreach (var name in nameList)
            {
                if (searchInput.ToLower() == name)
                {
                    Console.WriteLine(name);
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
