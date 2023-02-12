using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[] yourArray = { 1, 2, 3, 4, 5, 6 };
			string s = "";
			for (int i = 0; i < yourArray.Length; i++)
			{
				s += yourArray[i].ToString() + " ";
			}
			richTextBox1.Text = "Първоначално състояние на масива:\n" + s + "\n";

			int[] temp = new int[yourArray.Length + 1];
			if (yourArray != null)
			{
				Array.Copy(yourArray, temp, Math.Min(yourArray.Length, temp.Length));
			}
			yourArray = temp;
			yourArray[yourArray.Length - 1] = 7;
			s = "";
			for (int i = 0; i < yourArray.Length; i++)
			{
				s += yourArray[i].ToString() + " ";
			}
			richTextBox1.Text += "Състояние на масива след преоразмеряването му:\n" + s;
		}
	}
}
