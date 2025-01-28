double[] doubles=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
Func<double, double> addVat = num => num * 1.20;
foreach(double price in doubles)
{
    Console.WriteLine($"{addVat(price):f2}");
}