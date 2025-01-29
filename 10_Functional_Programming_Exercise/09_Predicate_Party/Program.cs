List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
string command;
while ((command = Console.ReadLine()) != "Party!")
{
    string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string action = commandParts[0];
    string criteriaType = commandParts[1];
    string argument = commandParts[2];

    Predicate<string> predicate = GetPredicate(criteriaType, argument);

    if (action == "Remove")
    {
        guests.RemoveAll(predicate);
    }
    else if (action == "Double")
    {
        List<string> matches = guests.FindAll(predicate);

        foreach (var guest in matches)
        {
            int index = guests.IndexOf(guest);
            guests.Insert(index + 1, guest);
        }
    }
}
if (guests.Any())
{
    Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
    static Predicate<string> GetPredicate(string criteriaType, string argument)
{
    return criteriaType switch
    {
        "StartsWith" => name => name.StartsWith(argument),
        "EndsWith" => name => name.EndsWith(argument),
        "Length" => name => name.Length == int.Parse(argument),11
        _ => throw new ArgumentException("Invalid criteria type")
    };
}

