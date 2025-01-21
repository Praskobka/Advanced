int n = int.Parse(Console.ReadLine());
Dictionary<string,List<decimal>> studentsAndGrades = new Dictionary<string, List<decimal>>();
for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = data[0];
    decimal grade = decimal.Parse(data[1]);
    if (!studentsAndGrades.ContainsKey(name))
    {
        studentsAndGrades.Add(name, new List<decimal>());
    }
    studentsAndGrades[name].Add(grade);
}
foreach (var (studentName, studentGrades) in studentsAndGrades)
{
    string grades = string.Join(" ", studentGrades.Select(x => x.ToString("F2")));
    Console.Write($"{studentName} -> {grades} (avg: {studentGrades.Average():f2})");
    Console.WriteLine();
}