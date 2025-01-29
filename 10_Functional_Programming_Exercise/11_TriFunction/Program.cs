int targetSum = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
string result = FindName(names, targetSum, (name, sum) => name.Sum(c => c) >= sum);
Console.WriteLine(result);
static string FindName(List<string> names, int targetSum, Func<string, int, bool> condition)
{
    return names.FirstOrDefault(name => condition(name, targetSum));
}
