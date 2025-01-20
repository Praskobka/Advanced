using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rowsLength = matrixSize[0];
            int colsLength = matrixSize[1];

            int[,] matrixRect = new int[rowsLength, colsLength];

            for (int row = 0; row < matrixRect.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrixRect.GetLength(1); col++)
                {
                    matrixRect[row, col] = elements[col];
                }
            }
            int maxSum = int.MinValue;
            int rowMaxIndex = 0;
            int colMaxIndex = 0;
            for (int row = 0; row < matrixRect.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrixRect.GetLength(1) - 2; col++)
                {
                    int sum = matrixRect[row, col] + matrixRect[row, col + 1] + matrixRect[row, col + 2]
                        + matrixRect[row + 1, col] + matrixRect[row + 1, col + 1] + matrixRect[row + 1, col + 2]
                        + matrixRect[row + 2, col] + matrixRect[row + 2, col + 1] + matrixRect[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowMaxIndex = row;
                        colMaxIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = rowMaxIndex; row < rowMaxIndex + 3; row++)
            {
                for (int col = colMaxIndex; col < colMaxIndex + 3; col++)
                {
                    Console.Write($"{matrixRect[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}