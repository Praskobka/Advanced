Stack<int> stack = new Stack<int>();
int nQueries = int.Parse(Console.ReadLine());
for (int i = 0; i < nQueries; i++)
{
    int[] commandInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int command = commandInfo[0];
    if (command == 1)
    {
        stack.Push(commandInfo[1]);
    }
    else if (command == 2)
    {
        stack.Pop();
    }
    else if (stack.Count > 0)
    {
        if (command == 3)
        {
            Console.WriteLine(stack.Max());
        }
        else
        {
            Console.WriteLine(stack.Min());
        }
    }
}
if (stack.Count > 0)
{
    Console.WriteLine(string.Join(", ", stack));
}
