using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_2_04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void RandomGenerateSales(int[][] sales)
		{
			Random rand = new Random();
			for (int month = 0; month < 12; month++)
			{
				for (int day = 0; day <= sales[month].GetUpperBound(0); day++)
				{
					sales[month][day] = rand.Next(500, 1000);
				}
			}
		}

		private string ViewSales(int[][] sales)
		{
			string s = "";
			for (int month = 0; month < 12; month++)
			{
				for (int day = 0; day <= sales[month].GetUpperBound(0); day++)
				{
					s += String.Format($"month = {(month + 1), 2}   day = {(day + 1), 3}\t sales = {sales[month][day]} \n");
				}
				s += "**********************************\n";
			}
			return s;
		}
		private string CalculateAverage(int[][] sales)
		{
			string s = "";
			double total, average;
			for (int month = 0; month < 12; month++)
			{
				total = 0.0;
				for (int day = 0; day <= sales[month].GetUpperBound(0); day++)
				{
					total += sales[month][day];
				}
				average = total / (sales[month].GetUpperBound(0) + 1);
				s += String.Format($"{(month + 1), 3}\t total = {total}\t average = {average: #.##}\n");
			}
			return s;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[] Jan = new int[31];
			int[] Feb = new int[28];
			int[] Mar = new int[31];
			int[] Apr = new int[30];
			int[] May = new int[31];
			int[] Jun = new int[30];
			int[] Jul = new int[31];
			int[] Aug = new int[31];
			int[] Sep = new int[30];
			int[] Oct = new int[31];
			int[] Nov = new int[30];
			int[] Dec = new int[31];

			int[][] sales = new int[12][] { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

			RandomGenerateSales(sales);
			richTextBox1.Text = ViewSales(sales);
			richTextBox1.Text += CalculateAverage(sales);

		}
	}
}
