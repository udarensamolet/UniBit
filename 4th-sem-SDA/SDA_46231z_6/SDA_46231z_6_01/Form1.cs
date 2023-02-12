using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_6_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			Hashing h = new Hashing();
			string[] names = new string[10];

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
			string name;
			int hashVal;
			richTextBox1.Text += "Обработените стойности са: \n";
			for (int i = 0; i < someNames.Length; i++)
			{
				name = someNames[i];
				hashVal = h.SimpleHash(name, names);
				richTextBox1.Text += "h(" + name + ") = " + hashVal.ToString() + "\n";
				names[hashVal] = name;
			}
			richTextBox1.Text += "\nЗаписаните стойности в масива са:\n";
			richTextBox1.Text += h.ShowDistrib(names);
		}
	}
}
