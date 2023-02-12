﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46231z_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.buttonOK.Enabled = false;
			//initiliasing tag property for validating entered data
			this.textBoxAddress.Tag = false;
			this.textBoxAge.Tag = false;
			this.textBoxName.Tag = false;
			this.textBoxName.Validating += new CancelEventHandler(TextBoxEmpty_Validating);
			this.textBoxAddress.Validating += new CancelEventHandler(TextBoxEmpty_Validating);
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			string output;

			output = "Име: " + this.textBoxName.Text + "\r\n"
				+ "Адрес: " + this.textBoxAddress.Text + "\r\n"
				+ "Професия: " + (string)(this.checkBoxProgrammer.Checked ? "Програмист" : "Не е програмист") + "\r\n"
				+ "Пол: " + (string)(this.radioButtonMan.Checked ? "Мъж" : "Жена") + "\r\n" 
				+ "Възраст: " + this.textBoxAge.Text;
			this.textBoxOutput.Text = output;
		}

		private void ButtonHelp_Click(object sender, EventArgs e)
		{
			string output;

			output = "Помощна информация:\r\n\r\n Име = Вашето име\r\n Адрес = Вашият адрес\r\n Програмист = Маркирайте полето, ако сте програмист \r\n Пол = Маркирайте своя пол \r\n Възраст = Вашата възраст ";
			this.textBoxOutput.Text = output;
		}

		private void ValidateOk()
		{
			this.buttonOK.Enabled = ((bool)(this.textBoxAddress.Tag) && (bool)(this.textBoxAge.Tag) && (bool)(this.textBoxName.Tag));
			//activatiung OK button when all Tag valuea are true
			this.buttonOK.Enabled = ((bool)(this.textBoxAddress.Tag) && (bool)(this.textBoxName.Tag) && (bool)(this.textBoxAge.Tag));
		}

		private void TextBoxEmpty_Validating(object sender, CancelEventArgs e)
		{
			//sender object
			TextBox tb = (TextBox)sender;

			//if some text is missing, setting color to red; validating data via Tag control
			if (tb.TextLength == 0)
			{
				tb.BackColor = Color.Red;
				tb.Tag = false;
				/*e.Cancel = True;*/
			}
			else
			{
				tb.BackColor = System.Drawing.SystemColors.Window;
				tb.Tag = true;
			}

			//calling ValidateOk method
			ValidateOk();
		}

		private void TextBoxAge_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if ((tb.Text.Length == 00) && (e.KeyChar == 48) || (e.KeyChar < 48) || (e.KeyChar > 57) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
		}

		private void TextBoxAge_KeyUp(object sender, KeyEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text.Length > 0)
			{
				if (Int16.Parse(tb.Text.ToString()) < 18)
				{
					tb.Tag = false;
					tb.BackColor = Color.Red;
				}
				else
				{
					tb.Tag = true;
					tb.BackColor = SystemColors.Window;
				}
				ValidateOk();
			}
		}

		private void TextBoxAge_Validating(object sender, CancelEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text.Length == 0)
			{
				tb.Tag = false;
				tb.BackColor = Color.Red;
			}
			ValidateOk();
		}

		private void TextBox_TextChanged (object sender, EventArgs e)
		{
			//converting sender object to TextBox type
			TextBox tb = (TextBox)sender;
			//checking values and setting values to Tag and background color properties
			{
				if (tb.Text.Length == 0)
				{
					tb.Tag = false;
					tb.BackColor = Color.Red;
				}
				else
				{
					tb.Tag = true;
					tb.BackColor = SystemColors.Window;
				}
			}
			//calling ValidateOk();
		}
	}
}
