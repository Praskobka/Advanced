Queue<string> people = new Queue<string>();
string input;
while((input = Console.ReadLine()) != "End")
{
    if (input != "Paid")
    {
        people.Enqueue(input);
    }
    else
    {
        foreach(string person in people)
        {
            Console.WriteLine(person);
        }
        people.Clear();
    }
}
Console.WriteLine($"{people.Count} people remaining.");