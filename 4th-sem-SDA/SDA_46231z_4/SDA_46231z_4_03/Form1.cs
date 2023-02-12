using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_4_03
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
			public Node NextLink;
			public Node PrevLink;
			public Node()
			{
				Element = null;
				NextLink = null;
				PrevLink = null;
			}

			public Node(Object elem)
			{
				Element = elem;
				NextLink = null;
				PrevLink = null;
			}
		}

		public class LinkedList
		{
			protected Node current;
			protected Node header;
			public int count;

			public LinkedList()
			{
				count = 0;
				header = new Node("header");
				header.NextLink = header;
				header.PrevLink = header;
			}

			public bool IsEmpty()
			{
				return (header.NextLink == null);
			}

			public void MakeEmpty()
			{
				header.NextLink = null;
			}
			public string PrintList()
			{
				string s = "";
				if (!IsEmpty())
				{
					Node current = new Node();
					current = header;
					for (int i = 0; i <= count + 1; i++)
					{
						s += String.Format($"{current.Element} -> ");
						current = current.NextLink;
					}
				}
				return s + "\n";
			}

			public string PrintReverse()
			{
				string s = "";
				if (!IsEmpty())
				{
					Node current = new Node();
					current = header;
					for (int i = 0; i <= count + 1; i++)
					{
						s += String.Format($"{current.Element} -> ");
						current = current.PrevLink;
					}
				}
				return s + "\n";
			}

			private Node Find(Object item)
			{
				Node current = new Node();
				current = header.NextLink;
				int c = 1;
				while (!object.Equals(current.Element, item) && c <= count)
				{
					current = current.NextLink;
					c++;
				}
				if (object.Equals(current.Element, item))
				{
					return current;
				}
				else
				{
					return null;
				}
			}

			public void Remove(Object item)
			{
				Node p = Find(item);
				if (p != null)
				{
					p.PrevLink.NextLink = p.NextLink;
					p.NextLink.PrevLink = p.PrevLink;
					p.NextLink = null;
					p.PrevLink = null;
					count--;
				}
			}

			public void InsertAfter(object newItem, object after)
			{
				Node current = new Node();
				current = Find(after);
				if (current != null)
				{
					Node newNode = new Node(newItem);
					newNode.NextLink = current.NextLink;
					newNode.PrevLink = current;
					current.NextLink.PrevLink = newNode;
					current.NextLink = newNode;
					count++;
				}
			}

			public void InsertFirst(Object newItem)
			{
				Node current = new Node(newItem);
				current.NextLink = header;
				header.NextLink = current;
				current.PrevLink = header;
				header.PrevLink = current;
				count++;
			}
		}

		LinkedList ll = new LinkedList();

		private void btnInsert_Click(object sender, EventArgs e)
		{
			ll.InsertFirst(textValue.Text);
			richTextBox1.Text += ll.PrintList();
			textValue.Text = "";
			btnInsertAfter.Enabled = true;
			btnRemove.Enabled = true;
			btnPrint.Enabled = true;
			btnInsert.Enabled = true;
		}

		private void btnInsertAfter_Click(object sender, EventArgs e)
		{
			ll.InsertAfter(textValue.Text, textAter.Text);
			richTextBox1.Text += ll.PrintList();
			textValue.Text = "";
			textAter.Text = "";

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			ll.Remove(textValue.Text);
			richTextBox1.Text += ll.PrintList();
			textValue.Text = "";
			if (ll.count == 0)
			{
				btnInsertAfter.Enabled = false;
				btnRemove.Enabled = false;
				btnPrint.Enabled = false;
				btnInsert.Enabled = true;

			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += ll.PrintList();
		}

		private void btnPrintRev_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += ll.PrintReverse();
		}
	}
}
