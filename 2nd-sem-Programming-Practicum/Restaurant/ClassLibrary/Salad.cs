using System;
using System.Collections.Generic;

namespace ClassLibrary
{
	public class Salad : Food
	{
		public Salad(string name, double grams, decimal price) : base(name, grams, price)
		{
		}
		public static List<Salad> saladList = new List<Salad>();
	}

}
