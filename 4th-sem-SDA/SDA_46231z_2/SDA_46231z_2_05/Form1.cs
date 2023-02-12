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

namespace SDA_46231z_2_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ShowArrayList1(object sender, ArrayList arr)
		{
			foreach (Object obarr in arr)
			{
				this.richTextBox1.Text += String.Format($"Тип = {obarr.GetType().ToString()}   \t Стойност = {obarr.ToString()}\n");
			}
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
			ArrayList arr = new ArrayList();
			arr.Add(95);
			arr.Add("София");
			int position;
			position = arr.Add(12.3);
			richTextBox1.Text = String.Format($"Стойността {arr[position]} е добавена в позиция {position}\n");

			arr.Insert(1, 111);
			arr.Insert(3, 333);
			ShowArrayList2(sender, arr, "След добавяне на два елемента чрез Insert()");

			richTextBox1.Text += String.Format($"\nТекущият капацитет на масива е {arr.Capacity}\n");
			richTextBox1.Text += String.Format($"\nБроят на изпозлваните елементи на масива е: {arr.Count}\n");

			if (arr.Contains(111))
			{
				arr.Remove(111);
			}
			else
			{
				richTextBox1.Text += "Няма такъв обект в масива.\n";
			}
			ShowArrayList2(sender, arr, "След изтриване на един елемент чрез Contains()");

			arr.RemoveAt(2);
			ShowArrayList2(sender, arr, "След изтриване на един елемент чрез RemoveAt()");

			position = arr.IndexOf(95);
			if (position != (-1))
			{
				arr.RemoveAt(position);
			}
			else
			{
				richTextBox1.Text += "Няма обект с такава стойност в масива.\n";
			}
			ShowArrayList2(sender, arr, "След изтриване на един елемент чрез IndexOf()  ");
		}
	}
}
