using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_7_04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			KeyValuePair<string, string>[] phoneBook = new KeyValuePair<string, string>[10];
			phoneBook[0] = new KeyValuePair<string, string>("0888999500", "Ректор");
			phoneBook[1] = new KeyValuePair<string, string>("0888999501", "Секретар");
			phoneBook[2] = new KeyValuePair<string, string>("0888999505", "Учебен отдел");
			phoneBook[3] = new KeyValuePair<string, string>("0888999515", "Счетоводство");

			for (int i = 0; i <= phoneBook.GetUpperBound(0); i++)
			{
				if (phoneBook[i].Key != null)
				{
					richTextBox1.Text += String.Format($"{phoneBook[i].Value}:\t {phoneBook[i].Key}\n");
				}
			}
		}
	}
}
