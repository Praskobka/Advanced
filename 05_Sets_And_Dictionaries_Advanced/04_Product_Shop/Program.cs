Dictionary<string,Dictionary<string,double>> shops=new Dictionary<string,Dictionary<string, double>>();
string input;
while ((input = Console.ReadLine()) != "Revision")
{
    string[] data=input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
    string shopName=data[0];
    if (!shops.ContainsKey(shopName))
    {
        shops.Add(shopName, new Dictionary<string, double>());
    }
    string productName=data[1];
    double productPrice = double.Parse(data[2]);
    shops[shopName].Add(productName, productPrice);
}
Dictionary<string, Dictionary<string, double>> shopsOrder = shops.OrderBy(n=>n.Key).ToDictionary(n=>n.Key,n=>n.Value);
foreach(var shop in shopsOrder)
{
    Console.WriteLine($"{shop.Key}->");
    foreach(var item in shop.Value)
    {
        Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
    }
}