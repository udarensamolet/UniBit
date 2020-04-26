using System;
using System.Collections.Generic;


namespace ClassLibrary
{
	public class Food : Product
	{
		public Food(string name, double grams, decimal price)
			: base(name, price)
		{
			this.Grams = grams;
		}

		public virtual double Grams { get; set; }
	}
}
