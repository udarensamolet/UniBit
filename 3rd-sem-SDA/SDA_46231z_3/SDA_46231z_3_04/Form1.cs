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

namespace SDA_46231z_3_04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Queue<string> clients = new Queue<string>();
			clients.Enqueue("Първи клиент");
			clients.Enqueue("Втори клиент");
			clients.Enqueue("Трети клиент");
			clients.Enqueue("Четвърти клиент");
			clients.Enqueue("Пети клиент");
			richTextBox1.Text = String.Format($"В опашката чакат {clients.Count} клиента.\n");

			foreach (string number in clients)
			{
				richTextBox1.Text += String.Format($"{number}\n");
			}

			richTextBox1.Text += String.Format($"Dequeue() - Обслужен '{clients.Dequeue()}'\n");
			richTextBox1.Text += String.Format($"Peek() - Кой е първи в опашката? - {clients.Peek()}\n");
			richTextBox1.Text += String.Format($"Dequeue() - Обслужен '{clients.Dequeue()}'");
			richTextBox1.Text += String.Format($"В опашката чакат {clients.Count()} клиента\n");

			richTextBox1.Text += String.Format("Създаване на нова опашка с метода ToArray():\n");
			Queue<string> queueCopy = new Queue<string>(clients.ToArray());
			foreach (string number in queueCopy)
			{
				richTextBox1.Text += String.Format($"{number}\n");
			}

			richTextBox1.Text += String.Format("Създаване на масив чрез метода CopyTo():\n");
			string[] array2 = new string[clients.Count];
			clients.CopyTo(array2, 0);
			for (int i = 0; i < array2.Length; i++)
			{
				richTextBox1.Text += String.Format($"array2[{i}] = {array2[i]}\n");
			}

			richTextBox1.Text += String.Format("Създаване на нова опашка от масив:\n");
			Queue<string> queueCopy2 = new Queue<string>(array2);
			foreach (string client in queueCopy2)
			{
				richTextBox1.Text += String.Format($"{client}\n");
			}

			richTextBox1.Text += String.Format($"Contains() - Във втората опашка има ли елемент 'Пети клиент'? Отговор: {queueCopy.Contains("Пети клиент")}\n");

			richTextBox1.Text += String.Format("queueCopy.Clear() - Втората опашка се изтрива.\n");
			queueCopy.Clear();

			richTextBox1.Text += String.Format($"queueCopy.Count = ? Броят на елементите във втората опашка е {queueCopy.Count}\n");
		}
	}
}
