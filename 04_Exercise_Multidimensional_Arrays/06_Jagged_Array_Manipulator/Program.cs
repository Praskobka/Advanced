int n = int.Parse(Console.ReadLine());
double[][] matrix = new double[n][];
for (int row = 0; row < n; row++)
{
    matrix[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
}
for (int row = 0; row < n - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        matrix[row] = matrix[row].Select(x => x * 2).ToArray();
        matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
    }
    else
    {
        matrix[row] = matrix[row].Select(x => x / 2).ToArray();
        matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
    }
}
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] data = input.Split();
    string command = data[0];
    int row = int.Parse(data[1]);
    int col = int.Parse(data[2]);
    double value = double.Parse(data[3]);
    if (row >= 0 && row < n)
    {
        if (col >= 0 && col < matrix[row].Length)
        {
            if (command == "Add")
            {
                matrix[row][col] += value;
            }
            else
            {
                matrix[row][col] -= value;
            }
        }
    }
}
for (int row = 0; row < n; row++)
{
    Console.WriteLine(string.Join(" ", matrix[row]));
}