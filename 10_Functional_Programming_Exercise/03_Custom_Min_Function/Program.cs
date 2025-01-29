int[] numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
Func<int[], int> customMin = number => number.Min();
Console.WriteLine(customMin(numbers));