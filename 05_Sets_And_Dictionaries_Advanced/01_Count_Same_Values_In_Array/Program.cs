double[] doubles=Console.ReadLine().Split().Select(double.Parse).ToArray();
Dictionary<double, int> dictionary=new Dictionary<double, int>();
int timesMet = 1;
for(int j=0; j<doubles.Length; j++)
{
    double number = doubles[j];
    for (int i = 0; i < doubles.Length; i++)
    {
        if (doubles[i] == number)
        {
            dictionary[doubles[j]] = timesMet++;
        }
    }
    timesMet = 1;
}
foreach(double key in dictionary.Keys)
{
    Console.WriteLine($"{key} - {dictionary[key]} times");
}