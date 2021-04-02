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

namespace SDA_46231z_3_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string MulBase(int n, int b)
		{
			Stack Digits = new Stack();
			string s = "", f;
			do
			{
				Digits.Push(n % b);
				n /= b;
			} while (n != 0);

			while (Digits.Count > 0)
			{
				f = Digits.Pop().ToString();
				switch (f)
				{
					case "10":
						s += "A";
						break;
					case "11":
						s += "B";
						break;
					case "12":
						s += "C";
						break;
					case "13":
						s += "D";
						break;
					case "14":
						s += "E";
						break;
					case "15":
						s += "F";
						break;
					default: s += f;
						break;
				}
			}
			return s;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int num, baseNum;
			num = Convert.ToInt32(textBoxNum.Text);
			baseNum = Convert.ToInt32(textBoxBaseNum.Text);
			richTextBox1.Text += String.Format($"{num} се конвертира към {MulBase(num, baseNum)} при основа {baseNum}.\n");
		}
	}
}
