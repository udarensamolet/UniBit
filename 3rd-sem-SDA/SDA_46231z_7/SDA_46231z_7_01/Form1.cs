using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_7_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		BulStat myBS = new BulStat();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string companyName = tbCompanyName.Text;
			string bs = tbBulStat.Text;
			if (companyName.Length == 0)
			{
				MessageBox.Show("Полето [Фирма] е празно!");
			}
			else if (bs.Length == 0)
			{
				MessageBox.Show("Полето [Булстат] е празно!");
			}
			else if (!myBS.Contains(companyName))
			{
				myBS.Add(companyName, bs);
				tbBulStat.Text = "";
				tbCompanyName.Text = "";
			}
			else
			{
				MessageBox.Show(String.Format($"Фирмата [{companyName}] вече е въведена!"));
			}
		}

		private void btnItem_Click(object sender, EventArgs e)
		{
			string companyName = tbCompanyName.Text;
			if (companyName.Length == 0)
			{
				MessageBox.Show("Полето [Фирма] е празно!");
			}
			else if (myBS.Contains(companyName))
			{
				richTextBox1.Text += String.Format($"Фирма: {companyName} - Булстат: {myBS.Item(companyName)} .\n");
			}
			else
			{
				richTextBox1.Text += String.Format($"Фирма с име [{companyName}] не съществува в речника.\n");
			}
		}

		private void btnCount_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += String.Format($"Брой елементи в речника: {myBS.Count}\n");
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			string companyName = tbCompanyName.Text;
			myBS.Remove(companyName);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			myBS.Clear();
		}

		private void btnShowDictionary_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += myBS.ShowDictionary();
		}
	}

	public class BulStat : DictionaryBase
	{
		public BulStat()
		{
		}
		public void Add(string companyName, string bs)
		{
			base.InnerHashtable.Add(companyName, bs);
		}
		public string Item(string companyName)
		{
			return base.InnerHashtable[companyName].ToString();
		}
		public void Remove(string companyName)
		{
			base.InnerHashtable.Remove(companyName);
		}
		public bool Contains(string companyName)
		{
			return base.InnerHashtable.Contains(companyName);
		}
		public string ShowDictionary()
		{
			string s;
			if (base.InnerHashtable.Count == 0)
			{
				s = "Речникът е празен\n.";
			}
			else
			{
				s = "Речник: \n";
			}
			foreach (object element in base.InnerHashtable.Keys)
			{
				string key = element.ToString();
				s += key + " - " + base.InnerHashtable[key].ToString() + "\n";
			}
			return s;
		}


	}
}
