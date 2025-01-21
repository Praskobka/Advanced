char[] word = Console.ReadLine().ToCharArray();
Dictionary<char,int> timesMet = new Dictionary<char,int>();
for (int i = 0; i < word.Length; i++)
{
    if (timesMet.ContainsKey(word[i]))
    {
        timesMet[word[i]]++;
    }
    else
    {
        timesMet.Add(word[i], 1);
    }
}
Dictionary<char,int> sortedTimesMet=timesMet.OrderBy(n => n.Key).ToDictionary(n=>n.Key,n=>n.Value);
foreach(char c in sortedTimesMet.Keys)
{
    Console.WriteLine($"{c}: {sortedTimesMet[c]} time/s");
}