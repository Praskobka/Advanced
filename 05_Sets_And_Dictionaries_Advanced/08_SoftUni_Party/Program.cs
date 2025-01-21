HashSet<string> vip=new HashSet<string>();
HashSet<string> regular=new HashSet<string>();
string input;
while ((input = Console.ReadLine()) != "PARTY")
{
    if (input.Length == 8)
    {
        if (char.IsDigit(input[0]))
        {
            vip.Add(input);
        }
        else
        {
            regular.Add(input);
        }
    }
}
while ((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
        vip.Remove(input);
    }
    else
    {
        regular.Remove(input);
    }
}
Console.WriteLine(vip.Count+regular.Count);
foreach(string id in vip)
{
    Console.WriteLine(id);
}
foreach(string id in regular)
{
    Console.WriteLine(id);
}