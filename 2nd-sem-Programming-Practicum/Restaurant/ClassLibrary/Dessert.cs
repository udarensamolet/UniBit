using System;
using System.Collections.Generic;

namespace ClassLibrary
{
	public class Dessert : Food
	{
		private double calories;
		public static List<Dessert> dessertsList = new List<Dessert>();
		public Dessert(string name, double grams, decimal price, double calories)
			: base(name, grams, price)
		{
			this.Calories = calories;
		}

		public virtual double Calories
		{
			get { return this.calories; }
			set { this.calories = value; }
		}

	}
}
