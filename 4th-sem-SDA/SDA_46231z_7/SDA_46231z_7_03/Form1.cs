using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_7_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		BulStat myBS = new BulStat("firms.txt");

		private void btnRun_Click(object sender, EventArgs e)
		{
			DictionaryEntry[] arrayBS = new DictionaryEntry[myBS.Count];
			myBS.CopyTo(arrayBS, 0);
			string s = "";  
			for (int i = 0; i <= arrayBS.GetUpperBound(0); i++)
			{
				s += String.Format($"Фирма: {arrayBS[i].Key}, Булстат: {arrayBS[i].Value}\n");
			}
			richTextBox1.Text = s;
		}
	}

	public class BulStat : DictionaryBase
	{
		public BulStat(string txtFile)
		{
			string line;
			string[] words;
			StreamReader inFile;
			inFile = File.OpenText(txtFile);
			while (inFile.Peek() != -1)
			{
				line = inFile.ReadLine();
				words = line.Split(',');
				this.InnerHashtable.Add(words[0], words[1]);
			}
			inFile.Close();
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
