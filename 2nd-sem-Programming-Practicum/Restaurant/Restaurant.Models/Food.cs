namespace Restaurant.Models
{
	public class Food : Product
	{
		public Food(string name, double grams, decimal price)
			: base(name, price)
		{
			Grams = grams;
		}

		public double Grams { get; set; }
	}
}
