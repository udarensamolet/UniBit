namespace Restaurant.Models
{
	public class Dessert : Food
	{
		private double _calories;
		public Dessert(string name, double grams, decimal price)
			: base(name, grams, price)
		{
		}

		public double Calories 
		{
			get => _calories;
			set
			{
				_calories = Grams * 3;
			}
		}
	}
}
