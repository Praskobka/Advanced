HashSet<string> uniqueUsernames = new HashSet<string>();
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
{
    uniqueUsernames.Add(Console.ReadLine());
}
foreach(string name in uniqueUsernames)
{
    Console.WriteLine(name);
}