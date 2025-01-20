int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[,] matrix = new int[sizes[0], sizes[1]];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}
string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] data = input.Split();
    if (data.Length == 5)
    {
        if (data[0] == "swap")
        {
            int matrixRows = matrix.GetLength(0);
            int matrixCols = matrix.GetLength(1);
            int row1 = int.Parse(data[1]);
            int col1 = int.Parse(data[2]);
            int row2 = int.Parse(data[3]);
            int col2 = int.Parse(data[4]);
            if (AreIndicesValid(matrixRows, matrixCols, row1, col1, row2, col2))
            {
                int number = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = number;
                for (int row = 0; row < matrixRows; row++)
                {
                    for (int col = 0; col < matrixCols; col++)
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
static bool AreIndicesValid(int matrixRows, int matrixCols, int row1, int col1, int row2, int col2)
{
    bool firstPairValid = row1 >= 0 && row1 < matrixRows && col1 >= 0 && col1 < matrixCols;
    bool secondPairValid = row2 >= 0 && row2 < matrixRows && col2 >= 0 && col2 < matrixCols;
    return firstPairValid && secondPairValid;
}