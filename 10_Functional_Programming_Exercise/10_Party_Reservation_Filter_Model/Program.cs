List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
List<(string filterType, string parameter)> filters = new List<(string, string)>();
string command;
while ((command = Console.ReadLine()) != "Print")
{
    string[] parts = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
    string action = parts[0];
    string filterType = parts[1];
    string parameter = parts[2];

    if (action == "Add filter")
    {
        filters.Add((filterType, parameter));
    }
    else if (action == "Remove filter")
    {
        filters.Remove((filterType, parameter));
    }
}
foreach (var (filterType, parameter) in filters)
{
    Predicate<string> predicate = GetPredicate(filterType, parameter);
    guests.RemoveAll(predicate);
}
Console.WriteLine(string.Join(" ", guests));
static Predicate<string> GetPredicate(string filterType, string parameter)
{
    return filterType switch
    {
        "Starts with" => name => name.StartsWith(parameter),
        "Ends with" => name => name.EndsWith(parameter),
        "Length" => name => name.Length == int.Parse(parameter),
        "Contains" => name => name.Contains(parameter),
        _ => throw new ArgumentException("Invalid filter type")
    };
}
