using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private double  fuelAmount;

		public double  FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}
		private double fuelConsumptionPerKilometer;

		public double FuelConsumptionPerKilometer
		{
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}
		private double travelledDistance;

		public double TravelledDistance
		{
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}
		public Car(string model,double fuelAmount,double fuelConsumptionPerKilometer)
		{
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumptionPerKilometer= fuelConsumptionPerKilometer;
			this.TravelledDistance = 0;
		}
		public void Drive(double distance)
		{
			double neededFuel=FuelConsumptionPerKilometer*distance;
			if(neededFuel > FuelAmount)
			{
                Console.WriteLine($"Insufficient fuel for the drive");
			}
			else
			{
				FuelAmount-=neededFuel;
				travelledDistance+=distance;
			}
		}
		public override string ToString()
		{
			return$"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
		}
	}
}
