using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> newPlanets = new List<string>() { "Xandar", "Hala" };

            planetList.AddRange(newPlanets);

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadLine();
        }
    }
}
