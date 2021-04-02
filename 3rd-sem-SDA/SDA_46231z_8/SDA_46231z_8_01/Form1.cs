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

namespace SDA_46231z_8_01
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

			string[] tempA = a.Split();
			string[] tempB = b.Split();

			foreach (string item in tempA)
			{
				setA.Add(item);
			}
			foreach (string item in tempB)
			{
				setB.Add(item);
			}

			richTextBox1.Text += String.Format("Множество А = {0}\n", setA.ToString());
			richTextBox1.Text += String.Format("Множество B = {0}\n", setB.ToString());

			setC = setA.Union(setB);
			richTextBox1.Text += String.Format("{0} обединение {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

			setC = setA.Intersection(setB);
			richTextBox1.Text += String.Format("{0} сечение {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

			setC = setA.Difference(setB);
			richTextBox1.Text += String.Format("{0} разлика {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

			if (setB.IsSubset(setA))
			{
				richTextBox1.Text += String.Format("{0} e подмножество на {1}\n", setB.ToString(), setA.ToString());
			}
			else
			{
				richTextBox1.Text += String.Format("{0} e подмножество на {1}\n", setA.ToString(), setB.ToString());
			}
		}
	}
	public class CSet
	{
		private Hashtable data;
		public CSet()
		{
			data = new Hashtable();
		}

		public void Add(Object item)
		{
			if (!(data.ContainsValue(item)))
			{
				data.Add(item, item);
			}
		}

		public string Hash(Object item)
		{
			char[] chars;
			string hashValue = "";
			string s = item.ToString();
			chars = s.ToCharArray();
			for (int i = 0; i <= chars.GetUpperBound(0); i++)
			{
				hashValue += (int)chars[i];
			}
			return hashValue.ToString();
		}

		public void Remove(Object item)
		{
			data.Remove(Hash(item));
		}
		public int Size()
		{
			return data.Count;
		}

		public CSet Union(CSet aSet)
		{
			CSet tempSet = new CSet();
			foreach (Object hashObject in data.Keys)
			{
				tempSet.Add(this.data[hashObject]);
			}
			foreach (Object hashObject in aSet.data.Keys)
			{
				if (!(this.data.ContainsKey(hashObject)))
				{
					tempSet.Add(aSet.data[hashObject]);
				}
			}
			return tempSet;
		}

		public CSet Intersection(CSet aSet)
		{
			CSet tempSet = new CSet();
			foreach (Object hashObject in data.Keys)
			{
				if (aSet.data.Contains(hashObject))
				{
					tempSet.Add(aSet.data[hashObject]);
				}
			}
			return tempSet;
		}

		public bool IsSubset(CSet aSet)
		{
			if (this.Size() > aSet.Size())
			{
				return false;
			}
			else
			{
				foreach (Object key in this.data.Keys)
				{
					if (!(aSet.data.Contains(key)))
					{
						return false;
					}
				}
			}
			return true;
		}
		public CSet Difference(CSet aSet)
		{
			CSet tempSet = new CSet();
			{
				foreach (Object hashObject in data.Keys)
				{
					if (!(aSet.data.Contains(hashObject)))
					{
						tempSet.Add(data[hashObject]);
					}
				}
				return tempSet;
			}
		}
		public override string ToString()
		{
			string s = "{";
			foreach (Object key in data.Keys)
			{
				s += data[key] + ", ";
			}
			if (s.Length > 2)
			{
				s = s.Substring(0, s.Length - 2);
			}
			return s + "}";
		}
	}
}
