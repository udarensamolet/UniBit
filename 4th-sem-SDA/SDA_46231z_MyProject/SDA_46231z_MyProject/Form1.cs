using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace SDA_46231z_MyProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Деклариране на списък, в който ще се съдържат регистрационните номера на ППС-тата
		List<string> vehicleInfo = new List<string>();
		// Деклариране на речника, който ще съдържа регистрационните номера за един собственик (ключ: собственик, стойност: речник от регистрационни номера и тип на ППС)
		Dictionary<string, Dictionary<string, string>> ownerInfo = new Dictionary<string, Dictionary<string, string>>();

		// Деклариране на променливите, в които ще се записват текущите данни на собственик и ППС
		string ownerNames;
		string registrationNumber;
		string type;

		// Метод за проверка на регистрационен номер
		private bool checkRegNumberValidity(string input)
		{
			bool valid = false;
			// Проверка дали регистрационният номер е с правилна дължина от 7 символа
			if (input.Length == 7)
			{
				// Проверка на валидност на първата буква
				switch (input[0])
				{
					case 'A':
					case 'B':
					case 'E':
					case 'K':
					case 'M':
					case 'H':
					case 'O':
					case 'P':
					case 'C':
					case 'T':
					case 'X':
					case 'Y':
						// Проверка дали следващите четири символи са цифри
						for (int i = 1; i <= 4; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 5; j <= 6; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
						break;
					default:
						valid = false;
						break;
				}
			}
			// Проверка дали регистрационният номер е с правилна дължина от 8 символа
			else if (input.Length == 8)
			{
				// Проверки на валидност на първата буква
				if (input[0] == 'B')
				{
					// Проверка на валидност на втората буква
					if (input[1] == 'H' || input[1] == 'P' || input[1] == 'T')
					{
						// Проверка дали следващите четири символа са цифри
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else if (input[0] == 'E')
				{
					if (input[1] == 'B')
					{
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else if (input[0] == 'K')
				{
					if (input[1] == 'H')
					{
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else if (input[0] == 'O')
				{
					if (input[1] == 'B')
					{
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else if (input[0] == 'P')
				{
					if (input[1] == 'A' || input[1] == 'B' || input[1] == 'P' || input[1] == 'K')
					{
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else if (input[0] == 'C')
				{
					if (input[1] == 'A' || input[1] == 'B' || input[1] == 'M' || input[1] == 'H' || input[1] == 'O' || input[1] == 'C' || input[1] == 'T')
					{
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else if (input[0] == 'T')
				{
					if (input[1] == 'X')
					{
						for (int i = 2; i <= 5; i++)
						{
							switch (input[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									for (int j = 6; j <= 7; j++)
									{
										switch (input[j])
										{
											case 'A':
											case 'B':
											case 'E':
											case 'K':
											case 'M':
											case 'H':
											case 'O':
											case 'P':
											case 'C':
											case 'T':
											case 'X':
											case 'Y':
												valid = true;
												break;
											default:
												valid = false;
												break;
										}
									}
									break;
								default:
									valid = false;
									break;
							}
						}
					}
					else
					{
						valid = false;
					}
				}
				else
				{
					valid = false;
				}
			}
			else
			{
				valid = false;
			}
			return valid;
		}

		// Деклариране на речник, в който ще се съдържа информация за тип на ППС и съответната цена
		Dictionary<string, double> priceList = new Dictionary<string, double>();
		private void btnPricelistCheck_Click(object sender, EventArgs e)
		{
			try
			{
				// Запълване на речника с данни за тип на ППС и съответната цена за месечен абонамент
				priceList["Ремарке"] = 1.5;
				priceList["Мотор"] = 1;
				priceList["Лека кола до 3,5 т."] = 2;
				priceList["МПС (между 3,5 т. и 7,5 т.)"] = 2.5;
				priceList["МПС (между 7,5 т. и 12 т.)"] = 3;
				priceList["МПС (над 12 т.)"] = 3.5;

				// Обхождане на елементите от речника
				foreach (var vehicle in priceList)
				{
					// Сравняване на избрания от потребителя тип на ППС и ключовете на елементите от речника
					if (lbPricelistType.SelectedItem.ToString() == vehicle.Key)
					{
						// Изписване на стойността на съответния ключ на дадения елемент от речника при съвпадение от направената проверка
						tbPricelistPrice.Text = $"{vehicle.Value:f2} лв./ден";
					}
				}
			}
			catch
			{
				MessageBox.Show("Моля изберете тип на ППС!");
			}
		}

		// Добавяне на ново ППС
		private void btnAddVehicle_Click(object sender, EventArgs e)
		{
			// Прочитане на имената на собственика
			ownerNames = tbAddVehicleOwnerNameFirst.Text + " " + tbAddVehicleOwnerNameLast.Text;

			// Прочитане на избрания тип на ППС
			try
			{
				type = cbAddVehiclePPSType.SelectedItem.ToString();
			}
			catch
			{
				MessageBox.Show("Моля изберете тип ППС !");
				return;
			}

			// Прочитане на регистрационния номер
			registrationNumber = tbAddVehiclePPSDKN.Text;

			// Проверка на регистрационния номер
			if (checkRegNumberValidity(registrationNumber))
			{
				// Проверка дали всички полета са попълнени
				if (ownerNames.Length > 1 && registrationNumber.Length > 0 && type.Length > 0)
				{
					// Проверка дали собственика вече е добавен към речника
					if (!ownerInfo.ContainsKey(ownerNames))
					{
						// Проверка дали регистрационния номер вече е добавен към списъка с регистрационни номера
						if (!vehicleInfo.Contains(registrationNumber))
						{
							// Добавяне на имената на собственика
							ownerInfo.Add(ownerNames, new Dictionary<string, string>());
							// Добавяне на информация за ППС към конкретния собственик
							ownerInfo[ownerNames].Add(registrationNumber, type);
							// Добавяне на регистрационния номер към списъка с регистрационни номера
							vehicleInfo.Add(registrationNumber);
						}
						else
						{
							MessageBox.Show("Err01* Вече има добавено ППС с този регистрационен номер към друг собственик!");
							return;
						}
					}
					else
					{
						// В случай, че такъв собственик вече е вкаран като елемент на външния речник, се проверява дали регистрационния номер е добавен към списъка с регистрационните номера
						if (!vehicleInfo.Contains(registrationNumber))
						{
							// Добавяне на информация за ППС към конкретния собственик
							ownerInfo[ownerNames].Add(registrationNumber, type);
							// Добавяне на регистрационния номер към списъка с регистрационни номера
							vehicleInfo.Add(registrationNumber);
						}
						else
						{
							MessageBox.Show("Err02* Вече има добавено ППС с този регистрационен номер към този собственик!");
							return;
						}
					}
				}
				else
				{
					MessageBox.Show("Моля попълнете всички полета!");
					return;
				}
			}
			else
			{
				MessageBox.Show("Моля въведете коректен регистрационен номер!");
				return;
			}

			// Извеждане на потвърждение за направен запис в речника
			rtbAddVehicleInfo.Text = $"За ППС с регистрационен номер {registrationNumber} и собственик {ownerNames} е запазено паркомясто за месеца!";
		}

		// Деклариране и инициализиране на променлива, която ще се използва за записване на общо дължимата сума за месеца
		double totalAll = 0;
		// Деклариране на променлива, в която ще се съдържа стойността на месеца
		string month;

		private void btnFinanceCalculateAll_Click(object sender, EventArgs e)
		{
			// Прочитане на месеца
			try
			{
				month = cbFinanceMonth.SelectedItem.ToString();
			}
			catch
			{
				MessageBox.Show("Моля изберете месец!");
				return;
			}

			totalAll = 0;
			rtbFinanceResult.Text = "Собственик\t|Регистрационен номер\t|Дължима сума за ППС\n";
			// Обхождане на външния речник
			foreach (var owner in ownerInfo)
			{
				// Обхождане на вътрешния речник
				foreach (var pps in owner.Value)
				{
					// Отпечатване на имената на собственика
					rtbFinanceResult.Text += $"{owner.Key}\t";
					// Отпечатване на регистрационния номер
					rtbFinanceResult.Text += $" {pps.Key}\t";
					// Проверка на типа на ППС и изчисляване и отпечатване на дължимата сума за него спрямо месеца, за който са въведени данни
					switch (pps.Value)
					{
						case "Ремарке":
							rtbFinanceResult.Text += $"\t {(1.5 * convertMonth(month)):F2} лв.\n";
							totalAll += (1.5 * convertMonth(month));
							break;
						case "Мотор":
							rtbFinanceResult.Text += $"\t {(1 * convertMonth(month)):F2} лв.\n";
							totalAll += (1 * convertMonth(month));
							break;
						case "Лека кола до 3,5 т.":
							rtbFinanceResult.Text += $"\t {(2 * convertMonth(month)):F2} лв.\n";
							totalAll += (2 * convertMonth(month));
							break;
						case "МПС (между 3,5 т. и 7,5 т.)":
							rtbFinanceResult.Text += $"\t {(2.5 * convertMonth(month)):F2} лв.\n";
							totalAll += (2.5 * convertMonth(month));
							break;
						case "МПС (между 7,5 т. и 12 т.)":
							rtbFinanceResult.Text += $"\t {(3 * convertMonth(month)):F2} лв.\n";
							totalAll += (3 * convertMonth(month));
							break;
						case "МПС (над 12 т.)":
							rtbFinanceResult.Text += $"\t {(3.5 * convertMonth(month)):F2} лв.\n";
							totalAll += (3.5 * convertMonth(month));
							break;
						default:
							rtbFinanceResult.Text += $"\t {(0 * convertMonth(month)):F2} лв.\n";
							totalAll += (0 * convertMonth(month));
							break;
					}
				}
			}
			// Отпечатване на цялата дължима сума за месеца
			rtbFinanceResult.Text += $"\nОбщо сума за получаване: {totalAll:f2} лв.";
		}

		// Метод за преобразуване на месец от string в int
		private int convertMonth(string input)
		{
			int monthDays;
			switch (input)
			{
				case "Януари":
				case "Март":
				case "Май":
				case "Юли":
				case "Август":
				case "Октомври":
				case "Декември":
					monthDays = 31;
					break;
				case "Февруари":
					monthDays = 28;
					break;
				case "Април":
				case "Юни":
				case "Септември":
				case "Ноември":
					monthDays = 30;
					break;
				default:
					monthDays = 0;
					break;
			}
			return monthDays;
		}

		// Деклариране на речник, който ще се използва, за да се изчислява дължимата сума по собственик
		Dictionary<string, double> ownerPayables = new Dictionary<string, double>();
		double totalOwner = 0;
		private void btnFinanceCalculateOwner_Click(object sender, EventArgs e)
		{
			// Обхождане на външен речник с цел да се проверят имената на собствениците
			foreach (var owner in ownerInfo)
			{
				// Проверка дали името на собственика фигурира в новия речник (ключ: собственик, стойност: дължима сума)
				if (!ownerPayables.ContainsKey(owner.Key))
				{
					// Добавяне на собственика, в случай, че името му не фигурира в новия речник
					ownerPayables.Add(owner.Key, totalOwner);

					// Обхождане на вътрешния речник, за да се провери типа на ППС
					foreach (var pps in owner.Value)
					{
						// Проверка на стойността на елементите от вътрешния речник и записването им в стойността на ключовете на елементите от новия речник
						switch (pps.Value)
						{
							case "Ремарке":
								ownerPayables[owner.Key] += (1.5 * convertMonth(month));
								break;
							case "Мотор":
								ownerPayables[owner.Key] += (1.0 * convertMonth(month));
								break;
							case "Лека кола до 3,5 т.":
								ownerPayables[owner.Key] += (2 * convertMonth(month));
								break;
							case "МПС (между 3,5 т. и 7,5 т.)":
								ownerPayables[owner.Key] += (2.5 * convertMonth(month));
								break;
							case "МПС (между 7,5 т. и 12 т.)":
								ownerPayables[owner.Key] += (3 * convertMonth(month));
								break;
							case "МПС (над 12 т.)":
								ownerPayables[owner.Key] += (3.5 * convertMonth(month));
								break;
							default:
								ownerPayables[owner.Key] += (0 * convertMonth(month));
								break;
						}
					}
				}
			}
			rtbFinanceResult.Text = "Собственик\tОбщо дължима сума\n";
			// Обхождане на новия речник
			foreach (var obj in ownerPayables)
			{
				// Отпечатване на ключовете и стойностите от новия речник
				rtbFinanceResult.Text += $"{obj.Key}\t{obj.Value:f2} лв.\n";
			}
		}
	}
}

