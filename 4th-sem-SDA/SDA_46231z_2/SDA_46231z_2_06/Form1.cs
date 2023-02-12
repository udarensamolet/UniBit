using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_2_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ShowArrayList2(object sender, ArrayList arr, string title)
		{
			int position = 0;
			richTextBox1.Text += String.Format($"\n{title}:\n");
			foreach (Object obarr in arr)
			{
				richTextBox1.Text += String.Format($"Позиция = {position}   \t Стойност = {obarr.ToString()}\n");
				position++;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ArrayList citiesOfDanube = new ArrayList();
			citiesOfDanube.Add("Видин");
			citiesOfDanube.Add("Оряхово");
			citiesOfDanube.Add("Никопол");
			citiesOfDanube.Add("Белене");
			ShowArrayList2(sender, citiesOfDanube, "Първи списък на градове");

			string[] newCities = new string[] {"Лом", "Козлодуй" };

			ArrayList moreCities = new ArrayList();
			moreCities.Add("Свищов");
			moreCities.Add("Русе");
			moreCities.Add("Тутракан");
			moreCities.Add("Силистра");

			citiesOfDanube.InsertRange(1, newCities);
			citiesOfDanube.AddRange(moreCities);
			ShowArrayList2(sender, citiesOfDanube, "Списък след добавяне чрез InsertRange и AddRange");

			ArrayList someCities = new ArrayList();
			someCities = citiesOfDanube.GetRange(2, 4);
			ShowArrayList2(sender, someCities, "Списък, получен с метода GetRange()");

			Object[] arrCities;
			arrCities = citiesOfDanube.ToArray();
			richTextBox1.Text += String.Format($"\nСписък, получен с метода ToArray()\n");
			for (int i = 0; i <= arrCities.GetUpperBound(0); i++)
			{
				richTextBox1.Text += String.Format($"Позиция = {i}   \t Стойност = {arrCities[i]} \n");
			}
		}
	}
}
