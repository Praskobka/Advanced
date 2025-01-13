int sizeOfSquare = int.Parse(Console.ReadLine());
int[,] matrixSquare = new int[sizeOfSquare, sizeOfSquare];
for (int r = 0; r < matrixSquare.GetLength(0); r++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int c = 0; c < matrixSquare.GetLength(1); c++)
    {
        matrixSquare[r, c] = data[c];
    }
}
int sumDiagonal = 0;
for (int r = 0; r < matrixSquare.GetLength(0); r++)
{
    sumDiagonal += matrixSquare[r, r];
}
Console.WriteLine(sumDiagonal);