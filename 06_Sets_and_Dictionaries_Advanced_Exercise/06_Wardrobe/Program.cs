﻿int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> wardrobe =new Dictionary<string, Dictionary<string, int>>();
for (int i = 0; i < n; i++)
{
    List<string> input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
    string colour = input[0];
    string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (!wardrobe.ContainsKey(colour))
    {
        wardrobe.Add(colour, new Dictionary<string, int>());
        for (int k = 0; k < clothes.Length; k++)
        {
            if (wardrobe[colour].ContainsKey(clothes[k]))
            {
                wardrobe[colour][clothes[k]]++;
            }
            else
            {
                wardrobe[colour].Add(clothes[k], 1);
            }
        }
    }
    else
    {
        for (int k = 0; k < clothes.Length; k++)
        {
            if (wardrobe[colour].ContainsKey(clothes[k]))
            {
                wardrobe[colour][clothes[k]]++;
            }
            else
            {
                wardrobe[colour].Add(clothes[k], 1);
            }
        }

    }
}
List<string> itemToFind = Console.ReadLine().Split().ToList();
foreach (var item in wardrobe)
{
    Console.WriteLine($"{item.Key} clothes:");
    foreach (var cloth in item.Value)
    {
        if (item.Key == itemToFind[0] && cloth.Key == itemToFind[1])
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
        }
    }

}