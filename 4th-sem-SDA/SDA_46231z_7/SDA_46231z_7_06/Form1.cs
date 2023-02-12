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

namespace SDA_46231z_7_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			phoneBookSL.Add("555", "IT отдел");
			phoneBookSL.Add("556", "IT отдел");
			phoneBookSL.Add("111", "Директор");
			phoneBookSL.Add("222", "Зам.-директор");
			phoneBookSL.Add("333", "Финансов отдел");
			phoneBookSL.Add("444", "Пласмент");

			ShowPhoneBook();
		}

		private void ShowPhoneBook()
		{
			if (phoneBookSL.Count != 0)
			{
				richTextBox1.Text += "Съдържание на речника-телефонен указател:\n";
				richTextBox1.Text += "Ключ\tСтойност\n";
				int i = 0;
				foreach (DictionaryEntry element in phoneBookSL)
				{
					richTextBox1.Text += String.Format($"{element.Value}:\t {element.Key}\n");
					i++;
				}
			}
			else
			{
				richTextBox1.Text += "Телефонният указател е празен.\n";
			}
		}

		SortedList phoneBookSL = new SortedList();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			string value = tbValue.Text;
			if (key.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Служител] е празно!\n");
			}
			else if (value.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Телефон] е празно!\n");
			}
			else if (phoneBookSL.ContainsKey(key) && phoneBookSL.ContainsValue(value))
			{
				richTextBox1.Text += String.Format($"Служител [{value}] и телефон [{key}] вече са въведени!\n");
			}
			else if (phoneBookSL.ContainsKey(key))
			{
				richTextBox1.Text += String.Format($"Телефонен номер [{key}] вече е въведен!\n");
			}
			else
			{
				phoneBookSL.Add(key, value);
				richTextBox1.Text += String.Format($"{value}: {key}\n");

			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			string value = tbValue.Text;
			if (key.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Служител] е празно!\n");
			}
			else if (value.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Телефон] е празно!\n");
			}
			else if (phoneBookSL.Contains(key) && phoneBookSL.Contains(value))
			{
				richTextBox1.Text += String.Format($"Изтриване на обект с данни:\n Служител: [{value}], Телефон [{key}]\n");
				phoneBookSL.Remove(key);
			}
			else
			{
				richTextBox1.Text += String.Format($"Не е намерен обект с данни: Служите: [{value}], Телефон [{key}]\n");
			}
		}

		private void btnRemoveAgent_Click(object sender, EventArgs e)
		{
			int id;
			string value = tbValue.Text;
			if (value.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Служител] е празно!\n");
			}
			else if (phoneBookSL.ContainsValue(value))
			{
				do
				{
					id = phoneBookSL.IndexOfValue(value);
					richTextBox1.Text += String.Format($"Изтриване на Служител: [{value}] Телефон: [{phoneBookSL.GetKey(id).ToString()}]\n");
					phoneBookSL.RemoveAt(id);
				} while (phoneBookSL.ContainsValue(value));
			}
			else
			{
				richTextBox1.Text += String.Format($"Не е намерен Служител: [{value}].\n");
			}
		}

		private void btnRemovePhone_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			int id;

			if (key.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Служител] е празно!\n");
			}
			else if (phoneBookSL.ContainsKey(key))
			{
				id = phoneBookSL.IndexOfKey(key);
				richTextBox1.Text += String.Format($"Изтриване на Телефон: [{key}] Служител: [{phoneBookSL.GetByIndex(id).ToString()}]\n");
			}
			else
			{
				richTextBox1.Text += String.Format($"Не е намерен Телефон: [{key}].\n");
			}
		}

		private void btnAgentSearch_Click(object sender, EventArgs e)
		{
			string value = tbValue.Text.ToString();
			if (value.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Служител] е празно!\n");
			}
			else
			{
				richTextBox1.Text += String.Format($"Tърсене на Служител: [{value}]\n");
				if (phoneBookSL.ContainsValue(value))
				{
					int id = phoneBookSL.IndexOfValue(value);
					for (int i = 0; i < phoneBookSL.Count; i++)
					{
						if (phoneBookSL.GetByIndex(i).ToString() == value)
						{
							richTextBox1.Text += String.Format($"Служител: [{value}] Телефон:[{phoneBookSL.GetKey(i).ToString()}]");
						}
					}
				}
				else
				{
					richTextBox1.Text += String.Format($"Не е намерен Служител: [{value}].\n");
				}
			}
		}

		private void btnPhoneSearch_Click(object sender, EventArgs e)
		{
			string key = tbKey.Text;
			if (key.Length == 0)
			{
				richTextBox1.Text += String.Format($"Полето [Телефон] е празно!\n");
			}
			else
			{
				richTextBox1.Text += String.Format($"Tърсене на Телефон: [{key}]\n");
				if (phoneBookSL.ContainsKey(key))
				{
					int id = phoneBookSL.IndexOfKey(key);
					richTextBox1.Text += String.Format($"Телефон:[{key}] Служител: [{phoneBookSL.GetByIndex(id).ToString()}]");
				}
				else
				{
					richTextBox1.Text += String.Format($"Не е намерен Телефон: [{key}].\n");
				}
			}

		}

		private void btnShowPhoneBook_Click(object sender, EventArgs e)
		{
			ShowPhoneBook();
		}

		private void btnCopyTo_Click(object sender, EventArgs e)
		{
			DictionaryEntry[] arrPhoneBook = new DictionaryEntry[phoneBookSL.Count];
			phoneBookSL.CopyTo(arrPhoneBook, 0);
			richTextBox1.Text += "Създаване на масив от arrPhoneBook\n" + "чрез метода CopyTo от речника phoneBook.\n";
			foreach (DictionaryEntry element in arrPhoneBook)
			{
				richTextBox1.Text += String.Format($"{element.Key}\t {element.Value}\n");
			}
		}
	}
}
