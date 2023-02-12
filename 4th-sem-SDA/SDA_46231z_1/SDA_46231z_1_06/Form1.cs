using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Node<T>
		{
			public T data;
			Node<T> link;
			public Node(T data, Node<T> link)
			{
				this.data = data;
				this.link = link;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Node<int> node1 = new Node<int>(100, null);
			Node<int> node2 = new Node<int>(200, node1);
			richTextBox1.Text = String.Format($"node1.data = {node1.data}\n");
			richTextBox1.Text += String.Format($"node2.data = {node2.data}\n");
		}
	}
}
