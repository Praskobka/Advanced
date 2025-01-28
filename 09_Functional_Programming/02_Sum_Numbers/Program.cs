int[] numbers=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Func < int[],int> countNumbers = arr=>arr.Length;
Func<int[], int> sumNumbers = arr=>arr.Sum();
Console.WriteLine(countNumbers(numbers));
Console.WriteLine(sumNumbers(numbers));