int[] ints=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] sorted=ints.OrderByDescending(n =>n).ToArray();
if(ints.Length <3||ints.Length == 3)
{
    Console.WriteLine(string.Join(" ",sorted));
}
else
{
    for(int i = 0; i < 3; i++)
    {
        Console.Write($"{sorted[i]} ");
    }
}