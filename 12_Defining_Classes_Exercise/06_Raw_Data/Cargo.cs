using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Cargo
    {
		private int cargoWeight;

		public int CargoWeight
		{
			get { return cargoWeight; }
			set { cargoWeight = value; }
		}
		private string cargoType;

		public string CargoType
		{
			get { return cargoType; }
			set { cargoType = value; }
		}
		public Cargo(int cargoWeight,string cargoType)
		{
			this.CargoType = cargoType;
			this.CargoWeight = cargoWeight;
		}
	}
}
