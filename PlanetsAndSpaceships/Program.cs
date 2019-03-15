using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> newPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(newPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            var spaceCrafts = new Dictionary<string, List<string>>();
            spaceCrafts.Add("Mars", new List<string> { "Surveyor", "Phoenix", "Mariner #3-9", "Viking"});
            spaceCrafts.Add("Mercury", new List<string> { "Mariner 10" });
            spaceCrafts.Add("Venus", new List<string> { "Mariner 2", "Soviet Venera 4", "Vega 1 and 2", "Venus Express" });
            spaceCrafts.Add("Earth", new List<string> { "Humans..." });
            spaceCrafts.Add("Uranus", new List<string> { "Voyager 2" });
            spaceCrafts.Add("Neptune", new List<string> { "Voyager 2" });
            spaceCrafts.Add("Jupiter", new List<string> { "Pioneer 11 and 12", "Voyagers I and II" });
            spaceCrafts.Add("Saturn", new List<string> { "Pioneer 11", "Voyager 1 and 2" });


            planetList.Remove("Pluto");

            foreach (var planet in planetList)
            {
                string spaceCraftString = "";
                foreach (var (planets, crafts) in spaceCrafts)
                {
                    if (planet == planets)
                    {
                        foreach (var craft in crafts)
                        {
                            spaceCraftString += " " + $"{craft}" + ",";
                        }
                    }

                }
                Console.WriteLine($"{planet}: {spaceCraftString.TrimEnd(',')}");

            }

            string rockyPlanetString = "";
            foreach( var planet in rockyPlanets)
            {
                rockyPlanetString += " " + $"{planet}" + ",";
            }
            Console.WriteLine($"The Rocky Planets Are: {rockyPlanetString.TrimEnd(',')}");
            Console.ReadLine();
        }
    }
}
