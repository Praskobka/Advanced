using _05_Filter_By_Age;

int n=int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();
for(int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(", ");
    Person person =new Person(data[0],int.Parse(data[1]));
    people.Add(person);
}
string condition=Console.ReadLine();
int threshold=int.Parse(Console.ReadLine());
string format=Console.ReadLine();
Func<Person, bool> filter = CreateFilter(condition, threshold);
Action<Person> printer = CreatePrinter(format);
PrintFilteredPeople(people, filter, printer);

static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
{
    if (condition == "older")
    {
        return person => person.Age >= ageThreshold;
    }
    else if (condition == "younger")
    {
        return person => person.Age < ageThreshold;
    }
    return person => false;
}
static Action<Person> CreatePrinter(string format)
{
    if (format == "name")
    {
        return person => Console.WriteLine(person.Name);
    }
    else if (format == "age")
    {
        return person => Console.WriteLine(person.Age);
    }
    else if (format == "name age")
    {
        return person => Console.WriteLine($"{person.Name} - {person.Age}");
    }
    return person => { };
}
static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
{
    foreach (var person in people)
    {
        if (filter(person))
        {
            printer(person);
        }
    }
}