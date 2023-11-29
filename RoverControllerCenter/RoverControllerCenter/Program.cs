using System;

/*
Welcome to SPACE: Space Program for Aeronautical Collection and Exploration. You are in charge of the Rover Control Center. All rovers on Moon and Mars are under your direction!

This project will show you some ways in which references, inheritance, interfaces, and arrays can help you be a better C# programmer.
*/

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {

            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);
            Rover[] rovers = { lunokhod, apollo, sojourner };
            DirectAll(rovers);
            Probe[] spaceobj = { lunokhod, apollo, sojourner, sputnik };
            foreach (Probe obj in spaceobj)
            {
                Console.WriteLine($"Traking a {obj.GetType()}");
            }
        }
        public static void DirectAll(Probe[] obj)
        {
            foreach (Probe o in obj)
            {
                Console.WriteLine(o.GetInfo());
                Console.WriteLine(o.Explore());
                Console.WriteLine(o.Collect());
            }
        }
    }
}
