using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_6_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Hashing h = new Hashing();
		private void btnRun_Click(object sender, EventArgs e)
		{
			string[] someNames = new string[]
				{
					"Дебора Белчева",
					"Станил Петров",
					"Калина Стефанова",
					"Кристина Йорданова",
					"Цветан Коларов",
					"Ива Аврамова",
					"Христиан Данаилов",
					"Радена Трифонова",
					"Емил Илиев",
					"Светослава Маджарова"
				};
			for (int i = 0; i < someNames.Length; i++)
			{
				string name = someNames[i];
				int hashVal = h.BetterHashing(name);
				h.hTable[hashVal] = name;
			}
			richTextBox1.Text = h.ShowDistrib();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string myValue = tbSearchText.Text;
			if (myValue.Length > 0)
			{
				MessageBox.Show(String.Format("Стойността \"{0}\" {1}.", myValue, h.ContainsValue(myValue) ? "е намерена в хеш-таблицата" : "не е намерена в хеш-таблицата"));
			}
			else
			{
				MessageBox.Show("Въведете текст за търсене!");
			}
		}
	}
}
