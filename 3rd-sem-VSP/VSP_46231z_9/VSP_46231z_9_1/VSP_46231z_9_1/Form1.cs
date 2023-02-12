using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46231z_9_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonShowMessage_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this.textBoxMessage.Text);
		}

	}
}
