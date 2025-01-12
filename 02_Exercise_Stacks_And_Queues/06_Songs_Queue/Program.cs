using System.Linq;

Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
while (songs.Count>0)
{
    string input = Console.ReadLine();
    string[] commands = input.Split();
    string type = commands[0];
    string song = "";
    for (int i = 1; i < commands.Length; i++)
    {
        song += $"{commands[i]} ";
    }
    song=song.TrimEnd();
    if (type == "Add")
    {
        if (songs.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            songs.Enqueue(song);
        }

    }
    else if (type == "Play")
    {
        songs.Dequeue();
    }
    else if (type == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
}
Console.WriteLine($"No more songs!");