string[] names = Console.ReadLine().Split();
Action<string> printKnights=name=>Console.WriteLine($"Sir {name}");
foreach(string name in names)
{
    printKnights(name);
}