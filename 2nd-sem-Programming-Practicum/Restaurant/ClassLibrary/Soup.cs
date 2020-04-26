using System;
using System.Collections.Generic;

namespace ClassLibrary
{
	public class Soup : Food
	{
		public static List<Soup> soupsList = new List<Soup>();
		public Soup(string name, double grams, decimal price) : base(name, grams, price)
		{
		}
	}
}
