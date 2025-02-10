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
            Person oldest = family.GetOlderstMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}