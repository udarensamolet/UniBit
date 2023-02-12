using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46231z_6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonBold_Click(object sender, EventArgs e)
		{
			Font oldFont, newFont;
			//assigning current shirt style of the marked text
			oldFont = this.richTextBoxText.SelectionFont;
			//if style == bold, remove format
			if (oldFont.Bold)
			{
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
			}
			//if style != bold, format in bold
			else
			{
				newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
			}
			//assigning new style to marked text
			this.richTextBoxText.SelectionFont = newFont;
			//passing to RichTextBox
			this.richTextBoxText.Focus();

		}

		private void ButtonUnderline_Click(object sender, EventArgs e)
		{
			Font oldFont, newFont;
			//assigning current shirt style of the marked text
			oldFont = this.richTextBoxText.SelectionFont;
			//if style == underline, remove format
			if (oldFont.Underline)
			{
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
			}
			//if style != underline, format in bold
			else
			{
				newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
			}
			//assigning new style to marked text
			this.richTextBoxText.SelectionFont = newFont;
			//passing to RichTextBox
			this.richTextBoxText.Focus();
		}

		private void ButtonItalic_Click(object sender, EventArgs e)
		{
			Font oldFont, newFont;
			//assigning current shirt style of the marked text
			oldFont = this.richTextBoxText.SelectionFont;
			//if style == italic, remove format
			if (oldFont.Italic)
			{
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
			}
			//if style != Italic, format in bold
			else
			{
				newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
			}
			//assigning new style to marked text
			this.richTextBoxText.SelectionFont = newFont;
			//passing to RichTextBox
			this.richTextBoxText.Focus();
		}

		private void ButtonCenter_Click(object sender, EventArgs e)
		{
			if (this.richTextBoxText.SelectionAlignment == HorizontalAlignment.Center)
			{
				this.richTextBoxText.SelectionAlignment = HorizontalAlignment.Left;
			}
			else
			{
				this.richTextBoxText.SelectionAlignment = HorizontalAlignment.Center;
			}
			this.richTextBoxText.Focus();
		}

		private void TextBoxSize_KeyPress(object sender, KeyPressEventArgs e)
		{
			//min size
			const int MinSize = 10;
			//chars, <Backspace> and <Enter> not allowed
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
			{
				e.Handled = true;
			}
			else if (e.KeyChar == 13)
			{
				//changing font size after pressing <Enter>
				TextBox txt = (TextBox)sender;
				if(Convert.ToInt16(txt.Text) < MinSize)
				{
					txt.Text = Convert.ToString(MinSize);
				}
				ApplyTextSize(txt.Text);
				e.Handled = true;
				this.richTextBoxText.Focus();
			}
		}

		private void ApplyTextSize(string textSize)
		{
			//converting text to float
			float newSize = Convert.ToSingle(textSize);
			FontFamily currentFontFamily;
			Font newFont;
			//creating a new font from the same family but in a different size
			currentFontFamily = this.richTextBoxText.SelectionFont.FontFamily;
			newFont = new Font(currentFontFamily, newSize);
			//format marker text into new shrift
			this.richTextBoxText.SelectionFont = newFont;
		}

		private void RichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}

		private void ButtonLoad_Click(object sender, EventArgs e)
		{
			try
			{
				//calling a method that generates an exception in case the file is not found or can't be loaded
				richTextBoxText.LoadFile(MyFile);
				MessageBox.Show("Файлът " + MyFile + "е зареден успешно.");
			}
			catch (System.IO.FileNotFoundException)
			{
				//if the try block generated an exception, the cath block is being executed
				MessageBox.Show("Не е намерен файлът " + MyFile);
			}
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			//saving the text to a file
			try
			{
				richTextBoxText.SaveFile(MyFile);
				MessageBox.Show("Файлът " + MyFile + " е съхранен успешно.");
			}
			catch (System.Exception error)
			{
				MessageBox.Show(error.Message);
			}
		}
	}
}
