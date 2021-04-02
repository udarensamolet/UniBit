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

namespace SDA_46231z_3_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Decimal Arithmetic(Decimal a, string oper, Decimal b, out bool isOK)
		{
			Decimal result = 0;
			isOK = true;
			switch (oper)
			{
				case "+":
					result = a + b;
					break;
				case "-":
					result = a - b;
					break;
				case "*":
					result = a * b;
					break;
				case "/":
					if (b != 0)
					{
						result = a / b;
					}
					else
					{
						isOK = false;
						result = 0;
					}
					break;
				default:
					break;
			}
			return result;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Decimal prevNum, currNum = 0;
			Decimal tmpNum;
			string inputText;
			string oper;
			const string operators = "+-*/";
			Stack revStack = new Stack();
			Stack stack = new Stack();
			inputText = textBox1.Text;
			richTextBox1.Clear();
			if (inputText.Length == 0)
			{
				return;
			}
			string[] temp = inputText.Split();
			foreach (String str in temp)
			{
				if (str.Length == 0)
				{
					continue;
				}

				if (Decimal.TryParse(str, out tmpNum))
				{
					stack.Push(str);
				}
				else
				{
					if (str.Length == 1 && (operators.Contains(str)))
					{
						stack.Push(str);
					}
					else
					{
						MessageBox.Show($"Непозната операция [{str}]");
						return;
					}
				}
			}

				if ((stack.Count < 3) || (stack.Count % 2) == 0)
				{
					MessageBox.Show("Стекът трябва да съдържа повече от два елемента.\nБроят на елементите трябва да е нечетен.\nИли операндите не са разделени с шпация.");
					return;
				}

				while (stack.Count > 0)
				{ 
					revStack.Push(stack.Pop());
				}
				prevNum = Decimal.Parse(revStack.Pop().ToString());
						bool isOk = true;

				while (revStack.Count > 0)
				{
					oper = revStack.Pop().ToString();
					currNum = Decimal.Parse(revStack.Pop().ToString());
					richTextBox1.Text += String.Format($"{prevNum} {oper} {currNum}\n");
					prevNum = Arithmetic(prevNum, oper, currNum, out isOk);
					if (!isOk)
					{
						richTextBox1.Text += String.Format($"Опит за деление на нула.\n");
						break;
					}
				}
				if (isOk)
				{
					richTextBox1.Text += String.Format($"{inputText} = {prevNum.ToString()}");
				}
			
		}
	}
}
