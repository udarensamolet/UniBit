using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_2_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[,] grades = new int[,] 
			{ 
				{ 3,5,2,3,6},
				{ 4,6,3,4,5},
				{ 5,4,4,3,4},
				{ 6,4,5,5,3}
			};
			int lastGrade = grades.GetUpperBound(1);
			double average = 0.0;
			int total;
			int lastStudent = grades.GetUpperBound(0);
			for (int row = 0; row <= lastStudent; row++)
			{
				total = 0;
				for (int col = 0; col <= lastGrade; col++)
				{
					total += grades[row, col];
				}
				average = (double)total / (double)(lastGrade + 1);
				richTextBox1.Text += String.Format($"Среден успех на студент: {row + 1} => {average}\n");
			}
		}
	}
}
