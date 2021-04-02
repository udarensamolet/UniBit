using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_3_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void DisplayArray(int[] n)
		{
			for (int i = 0; i <= n.GetUpperBound(0); i++)
			{
				richTextBox1.Text += String.Format($"n[{i}] = {n[i]}\n0");
			}
		}

		private void RadixSort(Queue[] que, int[] n, int digit)
		{
			int snum;
			for (int x = 0; x <= n.GetUpperBound(0); x++)
			{
				snum = n[x];
				for (int y = 2; y <= digit; y++)
				{
					snum = snum / 10;
				}
				snum = snum % 10;
				que[snum].Enqueue(n[x]);
				richTextBox1.Text += String.Format($"n[{x}] = {n[x]} => Опашка номер {snum}\n");
			}
		}

		private void BuildArray(Queue[] que, int[] n)
		{
			int y = 0;
			for (int x = 0; x <= 9; x++)
			{
				while (que[x].Count > 0)
				{
					n[y] = Int32.Parse(que[x].Dequeue().ToString());
					y++;
				}
			}
		}

		private int NumberOfDigits(int[] n)
		{
			int x = 0, max;
			if (n[0] < 0)
			{
				return 0;
			}
			else
			{
				max = n[0];
			}
			for (int i = 1; i <= n.GetUpperBound(0); i++)
			{
				if (n[i] < 0)
				{
					return 0;
				}
				if (max < n[i])
				{
					max = n[i];
				}
			}
			while (max > 0)
			{
				x++;
				max = max / 10;
			}
			return x;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Queue[] numQueue = new Queue[10];
			int[] nums = new int[] { 345, 556, 5645, 392, 251, 332, 416, 81, 5 };
			int dimention = NumberOfDigits(nums);
			if (dimention == 0)
			{
				richTextBox1.Text += String.Format("В данните не може да има отрицателни числа.");
				return;
			}
			else
			{
				richTextBox1.Text += String.Format($"Максимален брой разряди = {dimention}\n");
			}

			for (int i = 0; i < 10; i++)
			{
				numQueue[i] = new Queue();
			}
			for (int digit = 1; digit <= dimention; digit++)
			{
				richTextBox1.Text += String.Format("RadixSort()\n");
				RadixSort(numQueue, nums, digit);
				richTextBox1.Text += String.Format("BuildArray()\n");
				BuildArray(numQueue, nums);
				richTextBox1.Text += String.Format($"Масивът след {digit}-и пас:\n");
				DisplayArray(nums);
			}
		}
	}
}
