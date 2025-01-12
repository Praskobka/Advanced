Stack<int> stack=new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
string input;
while((input = Console.ReadLine().ToLower()) != "end")
{
    string[] data=input.Split();
    string command = (data[0]).ToLower();
    if(command == "add")
    {
        int number1=int.Parse(data[1]);
        int number2=int.Parse(data[2]);
        stack.Push(number1);
        stack.Push(number2);
    }
    else if(command == "remove")
    {
        int numbersToRemove=int.Parse(data[1]);
        if(stack.Count >= numbersToRemove)
        {
            for(int i = 0; i < numbersToRemove; i++)
            {
                stack.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");