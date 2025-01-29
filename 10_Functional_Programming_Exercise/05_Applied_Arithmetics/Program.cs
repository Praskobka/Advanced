using System.Data;
using System.Threading.Channels;

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
string input;
Func<int[], int[]> add = arr => arr.Select(x => x + 1).ToArray();
Func<int[], int[]> subtract = arr => arr.Select(x => x - 1).ToArray();
Func<int[], int[]> multiply = arr => arr.Select(x => x * 2).ToArray();
Func<int[], string> print = arr => string.Join(" ",arr);
int[] newArr = array;
while ((input = Console.ReadLine()) != "end")
{
    if (input == "add")
    {
        newArr = add(newArr);
    }
    else if(input == "multiply")
    {
        newArr=multiply(newArr);
    }
    else if (input == "subtract")
    {
        newArr= subtract(newArr);
    }
    else if (input == "print")
    {
        Console.WriteLine($"{print(newArr)}"); 
    }
}