int[] startEnd=Console.ReadLine().Split().Select(int.Parse).ToArray();
int start=startEnd[0];
int end=startEnd[1];
int[] ints = Enumerable.Range(start, end - start + 1).ToArray();
Predicate<int> condition=null;
string command=Console.ReadLine();
if (command == "odd")
{
    condition = x => x % 2 != 0;
}
else if(command == "even")
{
    condition=x=>x % 2 == 0;
}
int[] result=Array.FindAll(ints, condition);
Console.WriteLine(string.Join(" ", result));