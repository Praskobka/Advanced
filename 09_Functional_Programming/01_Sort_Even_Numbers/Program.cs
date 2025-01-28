int[] numbersToSort = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Func<int[], string> processNumbers = numbers =>
    string.Join(", ", numbers
        .Where(number => number % 2 == 0)
        .OrderBy(number => number));

Console.WriteLine(processNumbers(numbersToSort));