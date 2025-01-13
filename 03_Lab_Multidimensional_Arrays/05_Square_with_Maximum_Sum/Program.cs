int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
if (sizes[0] < 2 || sizes[1] < 2)
{
    return;
}
int[,] matrix = new int[sizes[0], sizes[1]];
for (int r = 0; r < matrix.GetLength(0); r++)
{
    int[] ints = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int c = 0; c < matrix.GetLength(1); c++)
    {
        matrix[r, c] = ints[c];
    }
}
int max = int.MinValue;
int rowSum = 0;
int colSum = 0;
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int squareSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
        if (squareSum > max)
        {
            max = squareSum;
            rowSum = row;
            colSum = col;
        }
    }
}
for (int row = rowSum; row < rowSum + 2; row++)
{
    for (int col = colSum; col < colSum + 2; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}
Console.WriteLine(max);