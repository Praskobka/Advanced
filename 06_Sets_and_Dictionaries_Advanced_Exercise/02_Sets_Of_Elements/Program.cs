int[] setSizes=Console.ReadLine().Split().Select(int.Parse).ToArray();
HashSet<int> set1 = new HashSet<int>();
HashSet<int> set2= new HashSet<int>();
int m=setSizes[0];
int n=setSizes[1];
for(int i = 0; i < m; i++)
{
    set1.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < n; i++)
{
    set2.Add(int.Parse(Console.ReadLine()));
}
set1.IntersectWith(set2);
Console.WriteLine(string.Join(" ",set1));