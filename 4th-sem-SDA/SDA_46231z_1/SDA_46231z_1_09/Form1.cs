using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_09
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BuildArray(int[] arr, int N)
		{
			for (int i = 0; i < N; i++)
			{
				arr[i] = i * i;
			}
		}

		private string DisplayNums(int[] arr)
		{
			string s = "";
			for (int i = 0; i <= arr.GetUpperBound(0); i++)
			{
				s += String.Format($"{arr[i]} = {arr[i]}\n");
			}
			return s;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TimeSpan startingTime, duration;
			startingTime = new TimeSpan(0);
			duration = new TimeSpan(0);
			const int N = 1000;
			int[] nums = new int[N];
			GC.Collect();
			GC.WaitForPendingFinalizers();
			startingTime = Process.GetCurrentProcess().UserProcessorTime;
			BuildArray(nums, N);
			richTextBox1.Text = DisplayNums(nums);
			duration = Process.GetCurrentProcess().UserProcessorTime.Subtract(startingTime);
			richTextBox1.Text += String.Format($"Общо време за изпълнение: {duration.TotalSeconds} секунди");
		}
	}
}
