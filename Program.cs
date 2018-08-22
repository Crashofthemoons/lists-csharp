using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastTwo = new List<string>() {"Neptune", "Uranus"};
            planetList.AddRange(lastTwo);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

                Dictionary<string,string> Venus = new Dictionary<string, string>{{"Venus", "Pioneer Venus Multiprobe"}};
                Dictionary<string, string> Mars = new Dictionary<string, string>{{"Mars", "Mars 3 Lander"}};
                Dictionary<string, string> Jupiter = new Dictionary<string, string>{{"Jupiter", "Pioneer 10"}};
                Dictionary<string, string> Saturn = new Dictionary<string, string>{{"Saturn", "Voyager 1"}};
                Dictionary<string, string> Uranus = new Dictionary<string, string>{{"Uranus", "Voyager 2"}};
                Dictionary<string, string> Neptune = new Dictionary<string, string>{{"Neptune", "Voyager 2"}};
                probes.Add(Venus);
                probes.Add(Mars);
                probes.Add(Jupiter);
                probes.Add(Saturn);
                probes.Add(Uranus);
                probes.Add(Neptune);

            foreach (string planet in planetList)
            {
                List<string> visitedProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes) {

                        if (probe.ContainsKey(planet)) {
                            visitedProbes.Add(probe[planet]);
                        }
                }
                if (visitedProbes.Count != 0) {
                    Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");

                }
            }

        }
    }
}
