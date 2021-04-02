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

namespace SDA_46231z_8_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			CSet setA = new CSet();
			CSet setB = new CSet();
			CSet setC = new CSet();

			string a = tbA.Text.TrimEnd();
			string b = tbB.Text.TrimEnd();

			if (a == "")
			{
				MessageBox.Show("Няма въведени данни за множество А!");
				return;
			}
			if (b == "")
			{
				MessageBox.Show("Няма въведени данни за множество B!");
				return;
			}

			string[] tempA = a.Split();
			string[] tempB = b.Split();

			foreach (string item in tempA)
			{
				int element = int.Parse(item);
				if (element > setA.Size() - 1)
				{
					MessageBox.Show($"Елементът {item} е по-голям от капацитета ({setA.Size().ToString()}) на масива в класа!");
					return;
				}
				setA.Add(element);
			}
			foreach (string item in tempA)
			{
				int element = int.Parse(item);
				if (element > setB.Size() - 1)
				{
					MessageBox.Show($"Елементът {item} е по-голям от капацитета ({setB.Size().ToString()}) на масива в класа!");
					return;
				}
				setB.Add(element);
			}


			richTextBox1.Text += String.Format("Множество А = {0}\n", setA.ToString());
			richTextBox1.Text += String.Format("Множество B = {0}\n", setB.ToString());

			setC = setA.Union(setB);
			richTextBox1.Text += String.Format("{0} обединение {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

			setC = setA.Intersection(setB);
			richTextBox1.Text += String.Format("{0} сечение {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

			setC = setA.Difference(setB);
			richTextBox1.Text += String.Format("{0} разлика {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());
			setC = setB.Difference(setA);
			richTextBox1.Text += String.Format("{0} разлика {1} = {2}\n", setB.ToString(), setA.ToString(), setC.ToString());

			if (setB.IsSubset(setA))
			{
				richTextBox1.Text += String.Format("{0} e подмножество на {1}\n", setB.ToString(), setA.ToString());
			}
			else
			{
				richTextBox1.Text += String.Format("{0} e подмножество на {1}\n", setA.ToString(), setB.ToString());
			}
		}

		public class CSet
		{
			private BitArray data;

			public CSet()
			{
				const int N = 100;
				data = new BitArray(N);
			}
			public void Add(int item)
			{
				data[item] = true;
			}
			public bool IsNumber(int item)
			{
				return data[item];
			}
			public void Remove(int item)
			{
				data[item] = false;
			}
			public CSet Union(CSet aSet)
			{
				CSet tempSet = new CSet();
				for (int i = 0; i <= data.Count - 1; i++)
				{
					tempSet.data[i] = (this.data[i] || aSet.data[i]);
				}
				return tempSet;
			}
			public CSet Intersection(CSet aSet)
			{
				CSet tempSet = new CSet();
				for (int i = 0; i <= data.Count - 1; i++)
				{
					tempSet.data[i] = (this.data[i] && aSet.data[i]);
				}
				return tempSet;
			}
			public CSet Difference(CSet aSet)
			{
				CSet tempSet = new CSet();
				for (int i = 0; i <= data.Count - 1; i++)
				{
					tempSet.data[i] = (this.data[i] && (!(aSet.data[i])));
				}
				return tempSet;
			}

			public bool IsSubset(CSet aSet)
			{
				CSet tempSet = new CSet();
				for (int i = 0; i <= data.Count - 1; i++)
				{
					if (this.data[i] && (!(aSet.data[i])))
					{
						return false;
					}
				}
				return true;
			}

			public override string ToString()
			{
				string s = "{";
				for (int i = 0; i <= data.Count - 1; i++)
					if (data[i])
					{
						s += i + ", ";
					}
				if (s.Length > 2)
				{
					s = s.Substring(0, s.Length - 2);
				}
				return s + "}";
			}
			public int Size()
			{
				return this.data.Count;
			}
		}
	}
}
