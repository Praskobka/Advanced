Queue<int> ints = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
int count=ints.Count;
List<int> numbers=new List<int>();
for (int i = 0; i < count; i++)
{
    int number=ints.Dequeue();
    if(number%2 == 0)
    {
        numbers.Add(number);
    }
}
Console.WriteLine(string.Join(", ",numbers));