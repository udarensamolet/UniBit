using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double c;
			string str_a, str_b;
			str_a = textBoxA.Text;
			str_b = textBoxB.Text;
			try
			{
				c = Double.Parse(str_a) * Double.Parse(str_b);
				textBoxC.Text = c.ToString();
			}
			catch (System.Exception err)
			{
				MessageBox.Show("Грешка във входните данни.\n" + "Моля въведете коректни данни.\n" + err);
			}

		}
	}
}
