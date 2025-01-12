int[] ints=Console.ReadLine().Split().Select(int.Parse).ToArray();
int nElements = ints[0];
int nPop = ints[1];
int nContains = ints[2];
Stack<int> stack = new Stack<int>(Console.ReadLine().Split(' ').Take(nElements).Select(int.Parse).ToArray());
for(int i = 0; i < nPop; i++)
{
    stack.Pop();
}
if(stack.Count > 0)
{
    if (stack.Contains(nContains))
    {
        Console.WriteLine($"true");
    }
    else
    {
        int minValue = int.MaxValue;
        foreach(int i in stack)
        {
            if(minValue > i)
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
