int squareSize=int.Parse(Console.ReadLine());
int[,] matrix=new int[squareSize,squareSize];
for(int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
    for(int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = numbers[col];
    }
}
int sumDiagonal1 = 0;
int sumDiagonal2 = 0;
int col1 = 0;
for(int row = 0;row < matrix.GetLength(0); row++)
{
    col1=matrix.GetLength(0)-1-row;
    sumDiagonal2 += matrix[row, col1];
    sumDiagonal1 += matrix[row,row];
}
Console.WriteLine(Math.Abs(sumDiagonal1-sumDiagonal2));