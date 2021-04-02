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

namespace SDA_46231z_1_10
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
			const int N = 1000;
			int[] nums = new int[N];
			BuildArray(nums, N);
			AlgorithmTimer at = new AlgorithmTimer();
			at.StartTime();
			richTextBox1.Text = DisplayNums(nums);
			at.StopTime();
			richTextBox1.Text += String.Format($"Общо време за изпълнение: {at.Result.TotalSeconds} секунди");

		}

		public class AlgorithmTimer
		{
			private TimeSpan startingTime, duration;
			public AlgorithmTimer()
			{
				startingTime = new TimeSpan(0);
				duration = new TimeSpan(0);
			}
			public void StartTime()
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				startingTime = Process.GetCurrentProcess().UserProcessorTime;
			}
			public void StopTime()
			{
				duration = Process.GetCurrentProcess().UserProcessorTime.Subtract(startingTime);
			}
			public TimeSpan Result
			{
				get
				{
					return duration;
				}
			}
		}
	}
}
