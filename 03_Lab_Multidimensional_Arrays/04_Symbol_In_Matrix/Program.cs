int sizeSquare = int.Parse(Console.ReadLine());
char[,] symbolMatrix = new char[sizeSquare, sizeSquare];
for (int r = 0; r < symbolMatrix.GetLength(0); r++)
{
    char[] chars = Console.ReadLine().ToArray();
    for (int c = 0; c < symbolMatrix.GetLength(1); c++)
    {
        symbolMatrix[r, c] = chars[c];
    }
}
bool charFound = false;
char charToFind = char.Parse(Console.ReadLine());
for (int r = 0; r < symbolMatrix.GetLength(0); r++)
{
    for (int c = 0; c < symbolMatrix.GetLength(1); c++)
    {
        if (symbolMatrix[r, c] == charToFind)
        {
            Console.WriteLine($"({r}, {c})");
            charFound = true;
            return;
        }
    }
}
if (!charFound)
{
    Console.WriteLine($"{charToFind} does not occur in the matrix");
}