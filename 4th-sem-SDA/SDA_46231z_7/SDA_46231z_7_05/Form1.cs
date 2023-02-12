using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_7_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			phoneBook.Add(new KeyValuePair<String, String>("111", "Директор"));
			phoneBook.Add(new KeyValuePair<String, String>("222", "Зам.-директор"));
			phoneBook.Add(new KeyValuePair<String, String>("333", "Финансов отдел"));
			phoneBook.Add(new KeyValuePair<String, String>("444", "Пласмент"));

			ShowPhoneBook();

		
		}
		private void ShowPhoneBook()
		{
			if (phoneBook.Count != 0)
			{
				richTextBox1.Text += "Съдържание на речника-телефонен указател:\n";
				foreach (KeyValuePair<string, string> element in phoneBook)
				{
					richTextBox1.Text += String.Format($"{element.Value}: \t{element.Key}\n");
				}
			}
			else
			{
				richTextBox1.Text += "Телефонният указател е празен.\n";
			}
		}

		ICollection<KeyValuePair<String, String>> phoneBook = new Dictionary<String, String>();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			string value = tbValue.Text;
			if (key.Length == 0)
			{
				MessageBox.Show("Полето [Служител] е празно!");
			}
			else if (value.Length == 0)
			{
				MessageBox.Show("Полето [Телефон] е празно!");
			}
			else if (!phoneBook.Contains(new KeyValuePair<String, String>(key, value)))
			{
				try
				{
					phoneBook.Add(new KeyValuePair<String, String>(key, value));
					richTextBox1.Text += String.Format($"{value}: \t{key}\n");
				}
				catch
				{
					MessageBox.Show(String.Format($"Телефонен номер [{key}] вече е въведен!"));
				}
			}
			else
			{
				MessageBox.Show(String.Format($"Служител [{value}] и телефон [{key}] вече са въведени!"));
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			string value = tbValue.Text;
			if (key.Length == 0)
			{
				MessageBox.Show("Полето [Служител] е празно!");
			}
			else if (value.Length == 0)
			{
				MessageBox.Show("Полето [Телефон] е празно!");
			}
			else
			{
				richTextBox1.Text += String.Format("Изтриване на обект с данни: " + $"Служител: [{value}], Телефон[{key}]\n");
				phoneBook.Remove(new KeyValuePair<String, String>(key, value));
			}
		}

		private void btnAgentSearch_Click(object sender, EventArgs e)
		{
			string value = tbValue.Text;
			if (value.Length == 0)
			{
				MessageBox.Show("Полето [Служител] е празно!");
			}
			else
			{
				richTextBox1.Text += String.Format($"Търсене на служител: [{value}]\n");
				foreach (KeyValuePair<string, string> element in phoneBook)
				{
					if (element.Value == value)
					{
						richTextBox1.Text += String.Format($"{element.Value}: {element.Key}\n");
					}
				}
			}
		}

		private void btnPhoneSearch_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			if (key.Length == 0)
			{
				MessageBox.Show("Полето [Телефон] е празно!");
			}
			else
			{
				richTextBox1.Text += String.Format($"Търсене на телефон: [{key}]\n");
				foreach (KeyValuePair<string, string> element in phoneBook)

				if(element.Key == key)
				{
						richTextBox1.Text += String.Format($"{element.Value}: {element.Key}\n");
				}
			}
		}

		private void btnCopyTo_Click(object sender, EventArgs e)
		{
			KeyValuePair<string, string>[] arrPhoneBook = new KeyValuePair<string, string>[phoneBook.Count];
			phoneBook.CopyTo(arrPhoneBook, 0);
			richTextBox1.Text += "Създаване на масив arrPhoneBook\n" + "чрез метода CopyTo от речника phoneBook.\n";
			foreach (KeyValuePair<string, string> element in arrPhoneBook)
			{
				richTextBox1.Text += String.Format($"{element.Value}: {element.Key}");
			}
		}

		private void btnShowPhoneBook_Click(object sender, EventArgs e)
		{
			ShowPhoneBook();
		}
	}
}
