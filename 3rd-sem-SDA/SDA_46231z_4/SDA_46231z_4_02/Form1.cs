using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_4_02
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
				while (current.NextLink != null)
				{
					current = current.NextLink;
				}
				newNode.NextLink = null;
				newNode.PrevLink = current;
				current.NextLink = newNode;
			}

			private Node Find(Object item)
			{
				Node current = new Node();
				current = header;
				while (current.NextLink != null && !object.Equals(current.Element, item))
				{
					current = current.NextLink;
				}
				return current;
			}

			public void InsertAfter(Object newItem, object after)
			{
				Node current = new Node();
				Node newNode = new Node(newItem);
				current = Find(after);
				newNode.NextLink = current.NextLink;
				newNode.PrevLink = current;
				current.NextLink.PrevLink = newNode;
				current.NextLink = newNode;
			}

			private Node FindPrevious(Object item)
			{
				Node current = header;
				while (current.PrevLink != null && object.Equals(current.PrevLink.Element, item))
				{
					current = current.PrevLink;
				}
				return current;
			}

			public void Remove(Object item)
			{
				Node p = FindPrevious(item);
				if (!(p.NextLink == null))
				{
					p.PrevLink.NextLink = p.NextLink;
					p.NextLink.PrevLink = p.PrevLink;
					p.NextLink = null;
					p.PrevLink = null;
				}
				else
				{
					p.PrevLink.NextLink = null;
					p.NextLink.PrevLink = null;
				}
			}

			public string PrintList()
			{
				Node current = new Node();
				current = header;
				string s = "";
				while (!(current.NextLink == null))
				{
					s += String.Format($"{current.NextLink.Element} -> ");
					current = current.NextLink;
				}
				return s + "null\n";
			}

			private Node FindLast()
			{
				Node current = new Node();
				current = header;
				while (!(current.NextLink == null))
				{
					current = current.NextLink;
				}
				return current;
			}

			public string PrintReverse()
			{
				Node current = new Node();
				current = FindLast();
				string s = "";
				while (!(current.PrevLink == null))
				{
					s += String.Format($"{current.Element} <- ");
					current = current.PrevLink;
				}
				
				return s + " null\n";
			}
			
		}

		LinkedList ll = new LinkedList();

		private void btnInsert_Click(object sender, EventArgs e)
		{
			ll.Insert(textValue.Text);
			richTextBox1.Text += ll.PrintList();
			textValue.Text = "";
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
