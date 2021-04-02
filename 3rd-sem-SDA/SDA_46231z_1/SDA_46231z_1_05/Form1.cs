﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Swap<T>(ref T val1, ref T val2)
		{
			T temp;
			temp = val1;
			val1 = val2;
			val2 = temp;
		}
		private void button1_Click(object sender, EventArgs e) 
		{
			int num1 = 100;
			int num2 = 200;
			richTextBox1.Text = "Първоначални стойности на две целочислени промениливи: \n";
			richTextBox1.Text += String.Format($"num1: {num1}; num2: {num2}\n");
			richTextBox1.Text += "Състояние след размяната на стойностите: \n";
			Swap<int>(ref num1, ref num2);
			richTextBox1.Text += String.Format($"num1: {num1}; num2: {num2}\n");

			string str1 = "София";
			string str2 = "Пловдив";
			richTextBox1.Text += "Първоначални стойности на два стринга:\n";
			richTextBox1.Text += String.Format($"str1: {str1}; str2: {str2}\n");
			richTextBox1.Text += "Състояние след размяната на стойностите: \n";
			Swap<string>(ref str1, ref str2);
			richTextBox1.Text += String.Format($"str1: {str1}; str2: {str2}\n");
		}
	}
}
