Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
int rackCapacity = int.Parse(Console.ReadLine());
int rackCount = 1;
int sum = 0;
while (stack.Count > 0)
{
    sum += stack.Peek();
    if (rackCapacity > sum)
    {
        stack.Pop();
    }
    else if (rackCapacity == sum)
    {
        stack.Pop();    
        if (stack.Count > 0)
        {
            rackCount++;
            sum = stack.Pop();
        }
        else
        {
            sum = 0;
        }

    }
    else if (rackCapacity < sum)
    {
        rackCount++;
        sum = stack.Pop(); 
    }

}
Console.WriteLine(rackCount);