using System;
using System.Collections.Generic;

namespace ClassLibrary
{
	public class Mains : Food
	{
		public static List<Mains> mainsList = new List<Mains>();
		private double calories;
		public Mains(string name, double grams, decimal price, double calories) : base(name, grams, price)
		{
		}
		public virtual double Calories
		{
			get { return this.calories; }
			set { this.calories = value; }
		}

	}
}
