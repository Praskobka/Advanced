int end = int.Parse(Console.ReadLine());
int[] ints = Enumerable.Range(1, end).ToArray();
int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Predicate<int> isDivisibleByAll = x => dividers.All(d => x % d == 0);
foreach (int i in ints)
{
    if (isDivisibleByAll(i))
    {
        Console.Write(i+ " ");
    }
}