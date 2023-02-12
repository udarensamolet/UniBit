using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_2_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[] nums;
			nums = new int[] { 0, 1, 2, 3, 4 };
			Type arrayType = nums.GetType();
			if (arrayType.IsArray)
			{
				richTextBox1.Text = String.Format($"Типът на масива е: {arrayType}");
			}
			else
			{
				richTextBox1.Text = String.Format("Не е масив");
			}
		}
	}
}
