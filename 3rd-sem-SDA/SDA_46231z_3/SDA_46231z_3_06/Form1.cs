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

namespace SDA_46231z_3_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private PriorityQueue<string> Queue = new PriorityQueue<string>();

		private void btnEnqueue_Click(object sender, EventArgs e)
		{
			string name;
			int priority;

			if (txtValue.Text != "")
			{
				name = txtValue.Text;
			}
			else
			{
				MessageBox.Show("Полето 'Процес не може да бъде празно.'");
				return;
			}

			bool result = int.TryParse(txtPriority.Text, out priority);
			if (result)
			{
				priority = int.Parse(txtPriority.Text);
			}
			else
			{
				MessageBox.Show("В полето 'Приоритет трябва да има число.'");
				return;
			}
			Queue.Enqueue(name, priority);
			richTextBox1.Text += String.Format($"Процес [{name}]\t Приоритет = {priority}.\n");
			txtValue.Clear();
			txtPriority.Clear();
			txtPriority.Focus();
			btnDequeue.Enabled = true;
		}

		private void btnDequeue_Click(object sender, EventArgs e)
		{
			string top_value;
			int top_priority;
			Queue.Dequeue(out top_value, out top_priority);
			txtValue.Text = top_value;
			txtPriority.Text = top_priority.ToString();
			btnDequeue.Enabled = (Queue.NumItems > 0);
		}
	}
}
