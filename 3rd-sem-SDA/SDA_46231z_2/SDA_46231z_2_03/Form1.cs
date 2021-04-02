using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_2_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = String.Format($"Метод sumNumsForeach \n");
			richTextBox1.Text += String.Format("sumNumsForeach{{1, 2 ,3}} => {0} \n", sumNumsForeach(new int[] { 1, 2, 3 }));
			richTextBox1.Text += String.Format("sumNumsForeach{{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}} => {0} \n", sumNumsForeach(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
			richTextBox1.Text += String.Format("sumNumsForeach{{}} => {0} \n", sumNumsForeach(new int[0]));

			richTextBox1.Text += String.Format($"\nМетод sumNumsFor \n");
			richTextBox1.Text += String.Format("sumNumsFor{{1, 2 ,3}} => {0} \n", sumNumsFor(new int[] { 1, 2, 3 }));
			richTextBox1.Text += String.Format("sumNumsFor{{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}} => {0} \n", sumNumsFor(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
			richTextBox1.Text += String.Format("sumNumsFor{{}} => {0} \n", sumNumsFor(new int[0]));

		}
		private int sumNumsForeach(params int[] args)
		{
			int sum = 0;
			foreach (int i in args)
			{
				sum += i;
			}
			return sum;
		}

		private int sumNumsFor(params int[] args)
		{
			int sum = 0;
			for (int i = 0; i <= args.GetUpperBound(0); i++)
			{
				sum += args[i];
			}
			return sum;
		}
	}
}
