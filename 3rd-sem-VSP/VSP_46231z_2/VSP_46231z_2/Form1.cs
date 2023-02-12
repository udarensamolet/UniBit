using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46231z_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonEnglish_Click(object sender, EventArgs e)
		{
			this.Text = "English";
		}

		private void ButtonBulgarian_Click(object sender, EventArgs e)
		{
			this.Text = "Български";
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
