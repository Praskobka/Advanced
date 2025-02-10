namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            int nCars = int.Parse(Console.ReadLine());
            for(int i = 0; i < nCars; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model=data[0];
                double fuelAmount=double.Parse(data[1]);
                double fuelPerKilometer=double.Parse(data[2]);
                Car car = new Car(model,fuelAmount,fuelPerKilometer);
                cars.Add(car);
            }
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();
                string command=data[0];
                if (command == "Drive")
                {
                    string model= data[1];
                    double distance = double.Parse(data[2]);
                    foreach(Car car in cars)
                    {
                        if(car.Model == model)
                        {
                            car.Drive(distance);
                        }
                    }
                }
            }
            foreach(Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}