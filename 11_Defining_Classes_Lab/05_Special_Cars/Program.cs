namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> listTires = new List<Tire[]>();
            string input;
            while((input = Console.ReadLine()) != "No more tires")
            {
                Tire[] tires=new Tire[4];
                string[] data = input.Split();
                int tiresIndex = 0;
                for(int i = 0; i < data.Length-1; i++)
                {
                    if (i % 2 == 0)
                    {
                        int year=int.Parse(data[i]);
                        double pressure=double.Parse(data[i+1]);
                        tires[tiresIndex]=new Tire(year, pressure);
                        tiresIndex++;
                    }           
                }
                listTires.Add(tires);
            }
            List<Engine> listEngine = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] data = input.Split();
                int horsePower = int.Parse(data[0]);
                double cubicCapacity = double.Parse(data[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                listEngine.Add(engine);
            }
            List<Car> listCars = new List<Car>();
            while((input = Console.ReadLine()) !="Show special")
            {
                string[] data = input.Split();
                string make=data[0];
                string model=data[1];
                int year=int.Parse(data[2]);
                double fuelQuantity=double.Parse(data[3]);
                double fuelConsumption=double.Parse(data[4]);
                int engineIndex=int.Parse(data[5]);
                int tireIndex=int.Parse(data[6]);
                if (engineIndex >= 0 && engineIndex < listEngine.Count && tireIndex >= 0 && tireIndex < listTires.Count)
                {
                    Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, listEngine[engineIndex], listTires[tireIndex]);
                    listCars.Add(car);
                }
            }
            double sum = 0;
            foreach (Car car in listCars)
            {
                foreach (Tire tire in car.Tires)
                {
                    sum += tire.Pressure;
                }
                if (car.Year >= 2017&&car.Engine.HorsePower>330&&(sum>=9&&sum<=10))
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
                sum = 0;
            }
        }
    }
}