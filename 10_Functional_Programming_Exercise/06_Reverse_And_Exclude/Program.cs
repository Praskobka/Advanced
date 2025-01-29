int[] numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
int n=int.Parse(Console.ReadLine());
Predicate<int> divisibleByN = null;
divisibleByN=x=>x%n==0;
for (int i = numbers.Length - 1; i >= 0; i--)
{
    if (!divisibleByN(numbers[i]))
    {
        Console.Write($"{numbers[i]} ");
    }
}