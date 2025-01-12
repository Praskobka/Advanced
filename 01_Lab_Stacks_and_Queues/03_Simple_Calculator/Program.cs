Stack<string> stack = new Stack<string>(Console.ReadLine().Split());
Stack<string> stackToUse = new Stack<string>(stack);
int result = int.Parse(stackToUse.Pop());
while (stackToUse.Count > 0)
{
    string operation = stackToUse.Pop();
    int nextNumber = int.Parse(stackToUse.Pop());

    if (operation == "+")
    {
        result += nextNumber;
    }
    else if (operation == "-")
    {
        result -= nextNumber;
    }
}
Console.WriteLine(result);
