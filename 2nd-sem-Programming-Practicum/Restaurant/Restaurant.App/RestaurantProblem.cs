using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using Restaurant.Models;

namespace Restaurant
{
	class RestaurantProblem
	{
		static void Main()
		{
			//create lists of diff types of products
			List<Beverage> beverages = new List<Beverage>();
            List<Dessert> desserts = new List<Dessert>();
            List<Mains> mains = new List<Mains>();
            List<Salad> salads = new List<Salad>();
            List<Soup> soups = new List<Soup>();

            Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.GetEncoding(1251);
			Console.Write("Hello there! Please tell me how many products are going to be on the menu: ");
			int countProducts = int.Parse(Console.ReadLine());
			int countInputProducts = 0;
			Console.WriteLine();


			char[] delimeters = new char[] { ',' };
			CultureInfo cultures = new CultureInfo("en-US");

			//check whether the user's number is ok
			while (true)
			{
				if (countProducts <= 0 || countProducts > 100)
				{
					Console.Write("This is not a valid number. Please try again: ");
					countProducts = int.Parse(Console.ReadLine());
					Console.WriteLine();
				}
				else
				{
					//menu input
					Console.WriteLine("Ok, thank you. Now start inputing them in the following order: {category}, {name}, {unit}, {price}.");
					Console.WriteLine();

					//assign to classes
					while(countInputProducts < countProducts)
					{
						Console.InputEncoding = Encoding.GetEncoding(1251); ;
						string[] inputProductInfo = Console.ReadLine()
							.ToLower()
							.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)
							.ToArray();

						if (inputProductInfo[0] == "salad" || inputProductInfo[0] == "салата")
						{
							Salad salad = new Salad(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
							bool contains = salads.Any(p => p.Name == salad.Name);
							if (contains == true)
							{
								Console.WriteLine("\nYou have already input this product. \n");
							}
							else
							{
								salads.Add(salad);
								countInputProducts++;
							}
						}

						if (inputProductInfo[0] == "soup" || inputProductInfo[0] == "супа")
						{
							Soup soup = new Soup(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
							bool contains = soups.Any(p => p.Name == soup.Name);
							if (contains == true)
							{
								Console.WriteLine("\nYou have already input this product. \n");
							}
							else
							{
								soups.Add(soup);
								countInputProducts++;
							}
						}

						if (inputProductInfo[0] == "main" || inputProductInfo[0] == "основно ястие")
						{
							Mains main = new Mains(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
							bool contains = mains.Any(p => p.Name == main.Name);
							if (contains == true)
							{
								Console.WriteLine("\nYou have already input this product. \n");
							}
							else
							{
								mains.Add(main);
								countInputProducts++;
							}
						}

						if (inputProductInfo[0] == "dessert" || inputProductInfo[0] == "десерт")
						{
							Dessert dessert = new Dessert(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
							bool contains = desserts.Any(p => p.Name == dessert.Name);
							if (contains == true)
							{
								Console.WriteLine("\nYou have already input this product. \n");
							}
							else
							{
                                desserts.Add(dessert);
								countInputProducts++;
							}
						}

						if (inputProductInfo[0] == "beverage" || inputProductInfo[0] == "напитка")
						{
							Beverage beverage = new Beverage(inputProductInfo[1], Convert.ToDouble(inputProductInfo[2], cultures), Convert.ToDecimal(inputProductInfo[3], cultures));
							bool contains = beverages.Any(p => p.Name == beverage.Name);
							if (contains == true)
							{
								Console.WriteLine("\nYou have already input this product. \n");
							}
							else
							{
								beverages.Add(beverage);
								countInputProducts++;
							}
						}
					}
				}
				break;
			}

		

			//time to take the orders
			Console.WriteLine();
			Console.WriteLine("Great job! Now please start entering orders and/or commands.");
			Console.WriteLine();

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
				

				//actions when just checking the balance during the day
				if (ordersAndCommands[0] == "продажби")
				{
					foreach (var table in tablesAndOrders)
					{
						if (table.Value > 0)
						{
							tablesCount++;
						}
					}
					Console.WriteLine();
					Console.WriteLine($"Total tables through the day: {tablesCount}");
					Console.WriteLine($"Total sales till now: {orderedItemsCount} - {salesBalance} BGN");
					Console.WriteLine("By categories: ");
					Console.WriteLine($" - Salads: {saladCount} - {saladBalance} BGN");
					Console.WriteLine($" - Soups: {soupCount} - {soupBalance} BGN");
					Console.WriteLine($" - Mains: {mainsCount} - {mainsBalance} BGN");
					Console.WriteLine($" - Desserts: {dessertCount} - {dessertBalance} BGN");
					Console.WriteLine($" - Beverages: {beverageCount} - {beverageBalance} BGN");
					Console.WriteLine();
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
					Console.WriteLine();
					Console.WriteLine($"Total tables through the day: {tablesCount}");
					Console.WriteLine($"Total sales till now: {orderedItemsCount} - {salesBalance} BGN");
					Console.WriteLine("By categories: ");
					Console.WriteLine($" - Salads: {saladCount} - {saladBalance} BGN");
					Console.WriteLine($" - Soups: {soupCount} - {soupBalance} BGN");
					Console.WriteLine($" - Mains: {mainsCount} - {mainsBalance} BGN");
					Console.WriteLine($" - Desserts: {dessertCount} - {dessertBalance} BGN");
					Console.WriteLine($" - Beverages: {beverageCount} - {beverageBalance} BGN");
					Console.WriteLine();
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
					foreach (var item in salads)
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
					foreach (var item in soups)
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
					foreach (var item in mains)
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
					foreach (var item in desserts)
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
					foreach (var item in beverages)
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
