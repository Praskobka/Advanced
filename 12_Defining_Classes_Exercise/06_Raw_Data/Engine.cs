﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Engine
    {
		private int speed;

		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		private int power;

		public int Power
		{
			get { return power; }
			set { power = value; }
		}
		public Engine(int speed,int power)
		{
			this.Speed = speed;
			this.Power = power;
		}
	}
}
