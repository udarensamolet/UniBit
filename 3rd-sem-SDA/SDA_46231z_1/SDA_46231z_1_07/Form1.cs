using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_07
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime startTime;
			TimeSpan endTime;
			const int N = 1000;
			int[] arr = new int[N];
			startTime = DateTime.Now;
			richTextBox2.Text = String.Format($"arr[{startTime.ToString()}]\n");
			for (int i = 0; i < N; i++)
			{
				arr[i] = i * i;
				richTextBox2.Text += String.Format($"arr[{i}] = {arr[i]}\n");
			}
			endTime = DateTime.Now.Subtract(startTime);
			richTextBox2.Text += String.Format($"Общо време за изпълнение: {endTime.ToString()}");
		}
	}
}
