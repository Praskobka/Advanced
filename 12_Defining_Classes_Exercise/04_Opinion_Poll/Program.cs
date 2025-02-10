namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split();
                Person person = new Person(data[0], int.Parse(data[1]));
                family.AddMember(person);
            }
            List<Person> peopleOver30= new List<Person>();
            foreach (Person person in family.People)
            {
                if (person.Age > 30)
                {
                    peopleOver30.Add(person);
                }
            }
            List<Person> sorted = peopleOver30.OrderBy(person => person.Name).ToList();
            foreach (Person person in sorted)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}