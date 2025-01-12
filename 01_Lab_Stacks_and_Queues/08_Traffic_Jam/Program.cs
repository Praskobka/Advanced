int carsToPass = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
int counter = 0;
string input;
while ((input = Console.ReadLine()) != "end")
{
    if (input != "green")
    {
        cars.Enqueue(input);
    }
    else if(input=="green")
    {
        if(cars.Count>=carsToPass)
        {
            for (int i = 0; i < carsToPass; i++)
            {
                string car = cars.Dequeue();
                Console.WriteLine($"{car} passed!");
                counter++;
            }
        }
        else
        {
            int count=cars.Count;
            for(int i = 0;i < count; i++)
            {
                string car = cars.Dequeue();
                Console.WriteLine($"{car} passed!");
                counter++;
            }
        }
        
    }
}
Console.WriteLine($"{counter} cars passed the crossroads.");