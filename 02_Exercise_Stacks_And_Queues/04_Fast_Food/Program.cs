int food = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
int max=queue.Max();
while(queue.Count > 0&&food > 0)
{
    if (food >= queue.Peek())
    {
        food-= queue.Peek();
        queue.Dequeue();
    }
    else
    {
        break;
    }
}
if (queue.Count > 0)
{
    Console.WriteLine(max);
    Console.Write("Orders left: ");
    foreach (int item in queue)
    {
        Console.Write($"{item} ");
    }
}
else
{
    Console.WriteLine(max);
    Console.WriteLine($"Orders complete"); 
}