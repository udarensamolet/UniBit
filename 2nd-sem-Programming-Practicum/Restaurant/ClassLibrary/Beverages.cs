using System;
using System.Collections.Generic;

namespace ClassLibrary
{
	public class Beverage : Product
	{
		public static List<Beverage> beveragesList = new List<Beverage>();
		private double calories;
		public Beverage(string name, double mililiters, decimal price, double calories)
			: base(name, price)
		{
			this.Milliliters = mililiters;
			this.Calories = calories;
		}
		public virtual double Milliliters { get; set; } //? taka li e
		public virtual double Calories
		{
			get { return this.calories; }
			set { this.calories = value; }
		}
	}
}
