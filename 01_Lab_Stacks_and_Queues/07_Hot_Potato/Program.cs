Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
int nTosses=int.Parse(Console.ReadLine());
int tosses = 1;
while (kids.Count > 1)
{
    string kid=kids.Dequeue();
    if (tosses == nTosses)
    {
        Console.WriteLine($"Removed {kid}");
        tosses = 0;
    }
    else
    {
        kids.Enqueue(kid);     
    }
    tosses++;
}
Console.WriteLine($"Last is {kids.Dequeue()}");