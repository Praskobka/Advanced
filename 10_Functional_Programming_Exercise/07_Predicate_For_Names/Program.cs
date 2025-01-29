int n=int.Parse(Console.ReadLine());
Predicate<int> isLength = x => x <=n;
string[] names = Console.ReadLine().Split();
foreach (string name in names)
{
    if (isLength(name.Length))
    {
        Console.WriteLine(name);
    }
}