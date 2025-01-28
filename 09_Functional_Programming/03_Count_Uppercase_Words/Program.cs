string[] words = Console.ReadLine().Split();
Func<string, bool> isUppercase = word => !string.IsNullOrEmpty(word) && char.IsUpper(word[0]);
foreach (string word in words.Where(isUppercase))
{
    Console.WriteLine(word);
}