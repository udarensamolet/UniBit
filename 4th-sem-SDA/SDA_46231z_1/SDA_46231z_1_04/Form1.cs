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

namespace SDA_46231z_1_04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Int16Collection : CollectionBase
		{
			public Int16 this[int index]
			{
				get
				{
					return ((Int16)List[index]);
				}
				set
				{
					List[index] = value;
				}
			}

			public int Add(Int16 value)
			{
				return (List.Add(value));
			}

			public int IndexOf(Int16 value)
			{
				return (List.IndexOf(value));
			}

			public void Insert(int index, Int16 value)
			{
				List.Insert(index, value);
			}

			public void Remove(Int16 value)
			{
				List.Remove(value);
			}

			public bool Contains(Int16 value)
			{
				return (List.Contains(value));
			}
		}

		public string ShowIndexAndValues(Int16Collection myCol)
		{
			string s = "";
			for (int i = 0; i < myCol.Count; i++)
			{
				s += String.Format($"   [{i}]:   {myCol[i]}\n");
			}
			return s;
		}

		public string ShowValues1(Int16Collection myCol)
		{
			string s = "";
			foreach (Int16 i16 in myCol)
			{
				s += String.Format($"   {i16}\n");
			}
			return s;
		}

		public string ShowValues2(Int16Collection myCol)
		{
			string s = "";
			IEnumerator myEnumerator = myCol.GetEnumerator();
			while (myEnumerator.MoveNext())
			{
				s += String.Format($"   {myEnumerator.Current}\n");
			}
			return s;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			Int16Collection myI16 = new Int16Collection();

			myI16.Add((Int16)1);
			myI16.Add((Int16)2);
			myI16.Add((Int16)3);
			myI16.Add((Int16)5);
			myI16.Add((Int16)7);

			richTextBox1.Text = "Съдържанието на колекцията (използва се foreach):\n";
			richTextBox1.Text += ShowValues1(myI16);
			richTextBox1.Text += "Съдържанието на колекцията (използва се enumerator):\n";
			richTextBox1.Text += ShowValues2(myI16);
			richTextBox1.Text += "Първоначално съдържание на колекцията (използва се Count и Item):\n";
			richTextBox1.Text += ShowIndexAndValues(myI16);
			richTextBox1.Text += String.Format($"В колекцията има ли стойност 3? - {myI16.Contains(3)}\n");
			richTextBox1.Text += String.Format($"Стойността 7 е в елемент с индекс {myI16.IndexOf(7)}\n");
			myI16.Insert(3, (Int16)12);
			richTextBox1.Text += "Съдържание на колекцията след добавяне на индекс 3:\n";
			richTextBox1.Text += ShowIndexAndValues(myI16);
			myI16[4] = 23;
			richTextBox1.Text += "Съдържание на колекцията след задаване на стойност 23 в индекс 4:\n";
			richTextBox1.Text += ShowIndexAndValues(myI16);
			myI16.Remove((Int16)2);
			richTextBox1.Text += "Съдържание на колекцията след премахване на елемент 2:\n";
			richTextBox1.Text += ShowIndexAndValues(myI16);
		}
	}
}
