string[] names = Console.ReadLine().Split();
Action<string> printName = (name) => Console.WriteLine(name);
foreach (string name in names)
{
    printName(name);
}