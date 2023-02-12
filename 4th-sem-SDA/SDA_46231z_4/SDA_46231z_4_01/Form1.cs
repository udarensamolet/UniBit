using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_4_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Node
		{
			public Object Element;
			public Node Link;
			public Node()
			{
				Element = null;
				Link = null;
			}
			public Node(Object elem)
			{
				Element = elem;
				Link = null;
			}
		}

		public class LinkedList
		{
			protected Node header;
			public LinkedList()
			{
				header = new Node("header");
			}

			public void Insert(Object newItem)
			{
				Node current = new Node();
				Node newNode = new Node(newItem);
				current = header;
				while (current.Link != null)
				{
					current = current.Link;
				}
				newNode.Link = current.Link;
				current.Link = newNode;
			}

			private Node Find(Object item)
			{
				Node current = new Node();
				current = header;
				while (current.Link != null && !object.Equals(current.Element, item))
				{
					current = current.Link;
				}
				return current;
			}

			public void InsertAfter(Object newItem, object after)
			{
				Node current = new Node();
				Node newNode = new Node(newItem);
				current = Find(after);
				newNode.Link = current.Link;
				current.Link = newNode;
			}

			private Node FindPrevious(Object item)
			{
				Node current = header;
				while (current.Link != null && object.Equals(current.Link.Element, item))	
				{
					current = current.Link;
				}
				return current;
			}

			public void Remove(Object item)
			{
				Node p = FindPrevious(item);
				if (!(p.Link == null))
				{
					p.Link = p.Link.Link;
				}
			}

			public string PrintList()
			{
				Node current = new Node();
				current = header;
				string s = "";
				while (!(current.Link == null))
				{
					s += String.Format($"{current.Link.Element} ->");
					current = current.Link;
				}
				return s + "null\n";
			}
		}

		LinkedList ll = new LinkedList();
		private void btnInsert_Click(object sender, EventArgs e)
		{
			ll.Insert(textBox1.Text);
			richTextBox1.Text += ll.PrintList();
			textBox1.Text = "";
		}

		private void btnInsertAfter_Click(object sender, EventArgs e)
		{
			ll.InsertAfter(textBox1.Text, textBox2.Text);
			richTextBox1.Text += ll.PrintList();
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			ll.Remove(textBox1.Text);
			richTextBox1.Text += ll.PrintList();
			textBox1.Text = "";
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += ll.PrintList();
		}
	}
}
