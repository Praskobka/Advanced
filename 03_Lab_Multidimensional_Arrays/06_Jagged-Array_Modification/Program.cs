int rowsCount = int.Parse(Console.ReadLine());
int[][] jagged = new int[rowsCount][];

for (int row = 0; row < jagged.Length; row++)
{
    string[] nums = Console.ReadLine().Split(' ');
    jagged[row] = new int[nums.Length];
    for (int col = 0; col < jagged[row].Length; col++)
    {
        jagged[row][col] = int.Parse(nums[col]);
    }
}

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] data = input.Split();
    string type = data[0];
    int row = int.Parse(data[1]);
    int col = int.Parse(data[2]);
    int num = int.Parse(data[3]);

    if (type == "Add")
    {
        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
        {
            jagged[row][col] += num;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    else if (type == "Subtract")
    {
        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
        {
            jagged[row][col] -= num;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
}

foreach (int[] row in jagged)
{
    Console.WriteLine(string.Join(" ", row));
}
