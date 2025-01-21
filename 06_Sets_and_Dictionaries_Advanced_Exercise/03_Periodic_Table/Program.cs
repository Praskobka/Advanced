int countOfLines=int.Parse(Console.ReadLine());
SortedSet<string> elements = new SortedSet<string>();
for(int i = 0; i < countOfLines; i++)
{
    string[] elementArray=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
    foreach (string element in elementArray)
    {
        elements.Add(element);
    }
}
Console.WriteLine(string.Join(" ",elements));