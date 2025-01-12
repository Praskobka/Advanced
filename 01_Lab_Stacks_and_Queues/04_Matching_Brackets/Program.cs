//1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
string input = Console.ReadLine();
char[] inputChar = input.ToCharArray();
Stack<int> indexOpenBracket = new Stack<int>();
Stack<int> indexCloseBracket = new Stack<int>();
for(int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        indexOpenBracket.Push(i);
    }
    else if (input[i] == ')')
    {
        indexCloseBracket.Push(i);
        for(int j = indexOpenBracket.Peek(); j <= indexCloseBracket.Peek(); j++)
        {
            Console.Write($"{input[j]}");
        }
        Console.WriteLine();
        indexOpenBracket.Pop();
        indexCloseBracket.Pop();
    }
}