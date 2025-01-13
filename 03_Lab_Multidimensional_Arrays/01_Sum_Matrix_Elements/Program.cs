int[] sizes = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int[,] matrix = new int[sizes[0], sizes[1]];
int sum = 0;
for (int r = 0; r < matrix.GetLength(0); r++)
{
    int[] col=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for(int c = 0;c<matrix.GetLength(1); c++)
    {
        sum += col[c];
        matrix[r,c]= col[c];
    }
}
Console.WriteLine(sizes[0]);
Console.WriteLine(sizes[1]);
Console.WriteLine(sum);