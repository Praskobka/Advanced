﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Tuple<T1,T2>
    {
		private T1 item1;

		public T1 Item1
		{
			get { return item1; }
			set { item1 = value; }
		}
		private T2 item2;

		public T2 Item2
		{
			get { return item2; }
			set { item2 = value; }
		}
		public Tuple(T1 item1,T2 item2)
		{
			this.Item1 = item1; 
			this.Item2 = item2;
		}
		public override string ToString()
		{
			return $"{this.Item1} -> {this.Item2}";
		}

	}
}
