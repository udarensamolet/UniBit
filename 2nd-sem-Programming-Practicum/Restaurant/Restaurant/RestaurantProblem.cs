using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Restaurant
{
	//all menu elements
	public class Product
	{
		private string name;
		private decimal price;
		public Product(string name, decimal price)
		{
			this.Name = name;
			this.Price = price;
		}
		public virtual string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}
		public virtual decimal Price
		{
			get { return this.price; }
			set { this.price = value; }
		}
	}

	//all Foods inherit Product
	public class Food : Product
	{
		public Food(string name, double grams, decimal price)
			: base(name, price)
		{
			this.Grams = grams;
		}

		public virtual double Grams { get; set; }
	}

	//Salads inherit Food
	public class Salad : Food
	{
		public Salad(string name, double grams, decimal price ) : base(name, grams, price)
		{
		}
		public static List<Salad> saladList = new List<Salad>();
	}

	//Soups inherit Food
	public class Soup : Food
	{
		public static List<Soup> soupsList = new List<Soup>();
		public Soup(string name, double grams, decimal price) : base(name, grams, price)
		{
			//soupsList.Add(this);
		}
	}

	//MainDishes inherit Food
	public class Mains : Food
	{
		public static List<Mains> mainsList = new List<Mains>();
		private double calories;
		public Mains(string name, double grams, decimal price, double calories) : base(name, grams, price)
		{
			//mainsList.Add(this);
		}
		public virtual double Calories
		{
			get { return this.calories; }
			set { this.calories = value; }
		}

	}

	//Desserts inherit Food
	public class Dessert : Food
	{
		private double calories;
		public static List<Dessert> dessertsList = new List<Dessert>();
		public Dessert(string name, double grams, decimal price, double calories)
			: base(name, grams, price)
		{
			this.Calories = calories;
			//dessertsList.Add(this);
		}

		public virtual double Calories
		{
			get { return this.calories; }
			set { this.calories = value; }
		}

	}

	//Beverages inherit Product
	public class Beverage : Product
	{
		public static List<Beverage> beveragesList = new List<Beverage>();
		private double calories;
		public Beverage(string name, double mililiters, decimal price, double calories)
			: base(name, price)
		{
			this.Milliliters = mililiters;
			this.Calories = calories;
			//beveragesList.Add(this);
		}
		public virtual double Milliliters { get; set; } //? taka li e
		public virtual double Calories
		{
			get { return this.calories; }
			set { this.calories = value; }
		}
	}


	class RestaurantProblem
	{
		static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.GetEncoding(1251); ;
			Console.Write("Hello there! Please tell me how many products are going to be on the menu: ");
			int countProducts = int.Parse(Console.ReadLine());
			Console.WriteLine("Ok, thank you. Now start inputing them in the following order: {category}, {name}, {unit}, {price}.");

			//menu input
			char[] delimeters = new char[] { ',' };
			CultureInfo cultures = new CultureInfo("en-US");

			//assign to classes
			for (int i = 0; i < countProducts; i++)

			{
				Console.InputEncoding = Encoding.GetEncoding(1251); ;
				string[] inputProductInfo = Console.ReadLine().ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
				
				if (inputProductInfo[0] == "salad" || inputProductInfo[0] == "салата")
				{
					Salad salad = new Salad(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
					Salad.saladList.Add(salad);
				}

				if (inputProductInfo[0] == "soup" || inputProductInfo[0] == "супа")
				{
					Soup soup = new Soup(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
					Soup.soupsList.Add(soup);
				}

				if (inputProductInfo[0] == "main" || inputProductInfo[0] == "основно ястие")
				{
					Mains main = new Mains(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures), Convert.ToDouble(inputProductInfo[2], cultures) * 1);
					Mains.mainsList.Add(main);
				}

				if (inputProductInfo[0] == "dessert" || inputProductInfo[0] == "десерт")
				{
					Dessert dessert = new Dessert(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures), Convert.ToDouble(inputProductInfo[2], cultures) * 3);
					Dessert.dessertsList.Add(dessert);
				}

				if (inputProductInfo[0] == "beverage" || inputProductInfo[0] == "напитка")
				{
					Beverage beverage = new Beverage(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures), Convert.ToDouble(inputProductInfo[2], cultures) * 3);
					Beverage.beveragesList.Add(beverage);
				}
			}

			//time to take the orders
			Console.WriteLine("Great job! Now please start entering orders and/or commands.");
			List<string> ordersAndCommands = new List<string>();
			int orderedItemsCount = 0;
			decimal salesBalance = 0;
			int salesCount = 0;
			int tableNumber = 0;
			int tablesCount = 0;

			int saladCount = 0;
			int soupCount = 0;
			int mainsCount = 0;
			int dessertCount = 0;
			int beverageCount = 0;

			decimal saladBalance = 0;
			decimal soupBalance = 0;
			decimal mainsBalance = 0;
			decimal dessertBalance = 0;
			decimal beverageBalance = 0;

			//assigning numbers to the tables
			IDictionary<int, int> tablesAndOrders = new Dictionary<int, int>();
			for (int i = 1; i <= 30; i++)
			{
				tablesAndOrders.Add(i, 0);
			}

			//receiving orders and commands
			while (true)
			{
				Console.InputEncoding = Encoding.GetEncoding(1251); 
				ordersAndCommands = Console.ReadLine().ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToList();
				
				//actions when just checking the balance for the day
				if (ordersAndCommands[0] == "продажби")
				{
					foreach (var table in tablesAndOrders)
					{
						if (table.Value > 0)
						{
							tablesCount++;
						}
					}
					Console.WriteLine($"Total tables through the day: {tablesCount}");
					Console.WriteLine($"Total sales till now: {orderedItemsCount} - {salesBalance} BGN");
					Console.WriteLine("By categories: ");
					Console.WriteLine($" - Salads: {saladCount} - {saladBalance} BGN");
					Console.WriteLine($" - Soups: {soupCount} - {soupBalance} BGN");
					Console.WriteLine($" - Mains: {mainsCount} - {mainsBalance} BGN");
					Console.WriteLine($" - Desserts: {dessertCount} - {dessertBalance} BGN");
					Console.WriteLine($" - Beverage: {beverageCount} - {beverageBalance} BGN");
				}

				//actions at the end of commercial day 
				else if (ordersAndCommands[0] == "изход")
				{
					tablesCount = 0;
					foreach (var table in tablesAndOrders)
					{
						if (table.Value > 0)
						{
							tablesCount++;
						}
					}
					Console.WriteLine($"Total tables through the day: {tablesCount}");
					Console.WriteLine($"Total sales till now: {orderedItemsCount} - {salesBalance} BGN");
					Console.WriteLine("By categories: ");
					Console.WriteLine($" - Salads: {saladCount} - {saladBalance} BGN");
					Console.WriteLine($" - Soups: {soupCount} - {soupBalance} BGN");
					Console.WriteLine($" - Mains: {mainsCount} - {mainsBalance} BGN");
					Console.WriteLine($" - Desserts: {dessertCount} - {dessertBalance} BGN");
					Console.WriteLine($" - Beverage: {beverageCount} - {beverageBalance} BGN");
					break;
				}

				//receiving orders
				else
				{
					orderedItemsCount = orderedItemsCount + (ordersAndCommands.Count - 1);

					tableNumber = Convert.ToInt32(ordersAndCommands[0]);
					if (tableNumber >= 1 && tableNumber <= 30)
					{
						tablesAndOrders[tableNumber]++;
					}
					else
					{
						throw new ArgumentOutOfRangeException("There is no such table!");
					}

					//calculating balance, orders, etc..
					foreach (var item in Salad.saladList)
					{
						for (int i = 1; i < ordersAndCommands.Count; i++)
						{
							if (item.Name == ordersAndCommands[i])
							{
								saladCount++;
								saladBalance += item.Price;
								salesCount++;
							}
						}
					}
					foreach (var item in Soup.soupsList)
					{
						for (int i = 1; i < ordersAndCommands.Count; i++)
						{
							if (item.Name == ordersAndCommands[i])
							{
								soupCount++;
								soupBalance += item.Price;
								salesCount++;
							}
						}
					}
					foreach (var item in Mains.mainsList)
					{
						for (int i = 1; i < ordersAndCommands.Count; i++)
						{
							if (item.Name == ordersAndCommands[i])
							{
								mainsCount++;
								mainsBalance += item.Price;
								salesCount++;
							}
						}
					}
					foreach (var item in Dessert.dessertsList)
					{
						for (int i = 1; i < ordersAndCommands.Count; i++)
						{
							if (item.Name == ordersAndCommands[i])
							{
								dessertCount++;
								dessertBalance += item.Price;
								salesCount++;
							}
						}
					}
					foreach (var item in Beverage.beveragesList)
					{
						for (int i = 1; i < ordersAndCommands.Count; i++)
						{
							if (item.Name == ordersAndCommands[i])
							{
								beverageCount++;
								beverageBalance += item.Price;
								salesCount++;
							}
						}
					}

					//total balance at the end of order
					salesBalance = saladBalance + soupBalance + mainsBalance + dessertBalance + beverageBalance;
				}
			}
		}
	}
}