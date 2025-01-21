using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, List<string>>> continentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string continent = input[0];
            string country = input[1];
            string city = input[2];
            if (!continentsCountriesCities.ContainsKey(continent))
            {
                continentsCountriesCities[continent] = new Dictionary<string, List<string>>();
            }
            if (!continentsCountriesCities[continent].ContainsKey(country))
            {
                continentsCountriesCities[continent][country] = new List<string>();
            }
            continentsCountriesCities[continent][country].Add(city);
        }
        foreach (var continent in continentsCountriesCities)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}
