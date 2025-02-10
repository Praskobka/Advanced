namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            int nCars=int.Parse(Console.ReadLine());
            for(int i = 0; i < nCars; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model=data[0];
                int engineSpeed=int.Parse(data[1]);
                int enginePower=int.Parse(data[2]);
                Engine engine =new Engine(engineSpeed, enginePower);
                int cargoWeight=int.Parse(data[3]);
                string cargoType=data[4];
                Cargo cargo=new Cargo(cargoWeight, cargoType);
                Tire[] carTires = new Tire[4];
                int tireIndex = 0;
                for(int j = 5; j < data.Length-1; j+=2)
                {
                    double tirePressure=double.Parse(data[j]);
                    int tireAge=int.Parse(data[j+1]);
                    carTires[tireIndex]=new Tire(tireAge, tirePressure);
                    tireIndex++;
                }
                Car car = new Car(model, engine, cargo, carTires);
                cars.Add(car);
            }
            string cargoInput=Console.ReadLine();
            if (cargoInput == "flammable")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.CargoType == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (cargoInput == "fragile")
            { 
                foreach(Car car in cars)
                {
                    if (car.Cargo.CargoType == "fragile")
                    {
                        foreach(Tire tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                Console.WriteLine(car.Model);
                                break;
                            }
                        }
                    }
                    
                }
            }
        }
    }
}