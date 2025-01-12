int[] commandInfo=Console.ReadLine().Split().Select(int.Parse).ToArray();
int nEnqueue = commandInfo[0];
int nDequeue=commandInfo[1];
int nContains=commandInfo[2];
Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Take(nEnqueue).Select(int.Parse).ToArray());
for(int i = 0; i < nDequeue; i++)
{
    queue.Dequeue();
}
if (queue.Count > 0)
{
    if (queue.Contains(nContains))
    {
        Console.WriteLine("true");
    }
    else
    {
        int minValue = int.MaxValue;
        foreach (int i in queue)
        {

            if (minValue > i)
            {
                minValue = i;
            }
        }
        Console.WriteLine(minValue);
    }
}
else
{
    Console.WriteLine(0);
}