Dictionary<int,int> evenTimes=new Dictionary<int,int>();
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
{
    int number=int.Parse(Console.ReadLine());
    if (evenTimes.ContainsKey(number))
    {
        evenTimes[number]++;
    }
    else
    {
        evenTimes.Add(number, 1);
    }
}
foreach(var timesMet in evenTimes)
{
    if (timesMet.Value % 2 == 0)
    {
        Console.WriteLine(timesMet.Key);
    }
}