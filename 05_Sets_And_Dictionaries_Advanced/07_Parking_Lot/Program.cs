HashSet<string> cars=new HashSet<string>();
string input;
while((input = Console.ReadLine()) != "END")
{
    string[] data=input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
    string inOrOut=data[0];
    string carNumber=data[1];
    if(inOrOut == "IN")
    {
        cars.Add(carNumber);
    }
    else if(inOrOut == "OUT")
    {
        cars.Remove(carNumber);
    }
}
if(cars.Count > 0)
{
    foreach(string car in cars)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}