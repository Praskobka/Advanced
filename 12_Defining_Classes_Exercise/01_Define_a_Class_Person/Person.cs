using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

	}
}
