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

namespace SDA_46231z_6_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRun1_Click(object sender, EventArgs e)
		{
			Hashtable s1 = new Hashtable();
			Hashtable s2 = new Hashtable(40);
			Hashtable s3 = new Hashtable(20, 0.3f);

			s3.Add("Заплата", 2500);
			s3.Add("Име", "Иван Иванов");
			s3.Add("Възраст", 33);
			s3.Add("Отдел", "Информационни технологии");
			richTextBox1.Text += String.Format($"Заплата = {s3["Заплата"].ToString()}\n");
			richTextBox1.Text += String.Format($"Име = {s3["Име"].ToString()}\n");
			richTextBox1.Text += String.Format($"Възраст = {s3["Възраст"].ToString()}\n");
			richTextBox1.Text += String.Format($"Отдел = {s3["Отдел"].ToString()}\n");

			s3["Пол"] = "Мъж";
			s3["Възраст"] = 34;
			try
			{
				s3.Add("Възраст", 34);
			}
			catch
			{
				richTextBox1.Text += String.Format("Елементът с ключ = 'Възраст' вече съществува.\n");
			}

			if (!s3.ContainsKey("Телефон"))
			{
				s3.Add("Телефон", "088889999");
				richTextBox1.Text += String.Format($"Стойността на добавения ключ \"Телефон\" е {s3["Телефон"]}.\n");
			}

			richTextBox1.Text += String.Format($"Пол = {s3["Пол"].ToString()}\n");
			richTextBox1.Text += String.Format($"Възраст = {s3["Възраст"].ToString()}\n");
		}

		private void btnRun2_Click(object sender, EventArgs e)
		{
			Hashtable myHT = new Hashtable(20);
			myHT.Add("Заплата", 2500);
			myHT.Add("Име", "Иван Петров");
			myHT.Add("Възраст", 34);
			myHT.Add("Отдел", "Информационни технологии");
			myHT.Add("Пол", "Мъж");
			myHT.Add("Телефон", 088889999);

			richTextBox1.Text += String.Format("Ключовете са следните: \n");
			foreach (Object key in myHT.Keys)
			{
				richTextBox1.Text += String.Format($"{key.ToString()}\n");
			}
			richTextBox1.Text += "\n";

			richTextBox1.Text += String.Format("Стойностите са следните: \n");
			foreach (Object value in myHT.Values)
			{
				richTextBox1.Text += String.Format($"{value.ToString()}\n");
			}
		}

		private void btnRun3_Click(object sender, EventArgs e)
		{
			Hashtable myHT = new Hashtable(20);
			myHT.Add("Заплата", 2500);
			myHT.Add("Име", "Иван Петров");
			myHT.Add("Възраст", 34);
			myHT.Add("Отдел", "Информационни технологии");
			myHT.Add("Пол", "Мъж");
			myHT.Add("Телефон", 088889999);

			richTextBox1.Text += String.Format("Ключовете са следните: \n");
			ICollection keyColl = myHT.Keys;
			foreach (Object s in keyColl)
			{
				richTextBox1.Text += String.Format($"{s}\n");
			}
			richTextBox1.Text += "\n";

			richTextBox1.Text += String.Format("Стойностите са следните: \n");
			ICollection valueColl = myHT.Values;
			foreach (Object s in valueColl)
			{
				richTextBox1.Text += String.Format($"{s}\n");
			}
		}

		private void btnRun4_Click(object sender, EventArgs e)
		{
			Hashtable myHT = new Hashtable(20);
			myHT.Add("Заплата", 2500);
			myHT.Add("Име", "Иван Петров");
			myHT.Add("Възраст", 34);
			myHT.Add("Отдел", "Информационни технологии");
			myHT.Add("Пол", "Мъж");
			myHT.Add("Телефон", 088889999);

			int i = 0;
			richTextBox1.Text += String.Format("\tИндекс\tКлюч\t\tСтойност\n");
			richTextBox1.Text += "=================================================\n";
			foreach (DictionaryEntry de in myHT)
			{
				richTextBox1.Text += String.Format($"\t[{i++}]:\t{de.Key}\t\t{de.Value}\n");
			}
		}

		private void btnRun5_Click(object sender, EventArgs e)
		{
			Hashtable myHT = new Hashtable(20);
			myHT.Add("Заплата", 2500);
			myHT.Add("Име", "Иван Петров");
			myHT.Add("Възраст", 34);
			myHT.Add("Отдел", "Информационни технологии");
			myHT.Add("Пол", "Мъж");
			myHT.Add("Телефон", 088889999);

			int i = 0;
			richTextBox1.Text += String.Format("\tИндекс\tКлюч\t\tСтойност\n");
			richTextBox1.Text += "=================================================\n";
			foreach (Object key in myHT.Keys)
			{
				richTextBox1.Text += String.Format($"\t[{i++}]:\t{key.ToString()}\t\t{myHT[key].ToString()}\n");
			}
		}

		private void btnRun6_Click(object sender, EventArgs e)
		{
			Hashtable myHT = new Hashtable();
			myHT.Add("червена", 1);
			myHT.Add("жълта", 2);
			myHT.Add("зелена", 3);
			myHT.Add("кафява", 4);
			myHT.Add("синя", 5);
			myHT.Add("розова", 6);
			myHT.Add("черна", 7);

			richTextBox1.Text += "Хеш таблицата съдържа следните стойности:\n";
			richTextBox1.Text += "=========================================\n";
			richTextBox1.Text += String.Format("Ключ\t\tСтойност\n");
			richTextBox1.Text += "=========================================\n";
			foreach (Object key in myHT.Keys)
			{
				richTextBox1.Text += String.Format($"{key.ToString()}\t\t{myHT[key].ToString()}\n");
			}
			richTextBox1.Text += "=========================================\n";

			string myKey = "розова";
			richTextBox1.Text += String.Format("Ключът \"{0}\" {1}\n", myKey, myHT.ContainsKey(myKey) ? "е намерен в хеш таблицата." : "не е намерен в хеш таблицата.");

			myKey = "оранжева";
			richTextBox1.Text += String.Format("Ключът \"{0}\" {1}\n", myKey, myHT.ContainsKey(myKey) ? "е намерен в хеш таблицата." : "не е намерен в хеш таблицата.");

			int myValue = 2;
			richTextBox1.Text += String.Format("Стойността \"{0}\" {1}\n", myValue, myHT.ContainsValue(myValue) ? "е намерена в хеш таблицата." : "не е намерена в хеш таблицата.");

			myValue = 9;
			richTextBox1.Text += String.Format("Стойността \"{0}\" {1}\n", myValue, myHT.ContainsValue(myValue) ? "е намерена в хеш таблицата." : "не е намерена в хеш таблицата.");
		}
	}
}
