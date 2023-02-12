using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46231z_10
{
	public partial class FormAnimalInfo : Form
	{
		public FormAnimalInfo()
		{
			InitializeComponent();
		}


	
		//метод за валидиране дали текстовите полета са празни
		private void TextBoxEmpty_Validating(object sender, CancelEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			//проверка дали дължината на въведения текст от съответното текстово поле е равна на 0
			if (tb.Text.Length == 0)
			{
				//ако дължината на въведения текст е равна на 0, се оцветява полето в червено
				tb.BackColor = Color.Red;
			}
			else
			{
				//ако дължината на въведения текст е различна от 0, се приема стандартния цвят на Windows
				tb.BackColor = SystemColors.Window;
			}
		}

		//проверка дали телефонният номер е въведен в коректен формат
		private void TextBoxOwnerPhone_Validating(object sender, CancelEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			//проверява се дали въведеният номер е съставен от 10 цифри
			if (tb.Text.Length == 10)
			{
				//проверка дали въведеният номер започва с 0 на първо място и 8 на второ място
				if (tb.Text[0] == '0' && tb.Text[1] == '8')
				{
					//проверка дали въведеният номер съдържа стандартните за България цифри на трето място
					if (tb.Text[2] == '7' || tb.Text[2] == '8' || tb.Text[2] == '9')
					{
						//проверка дали останалите въведени символи са цифри
						for (int i = 3; i < tb.Text.Length - 1; i++)
						{
							switch (tb.Text[i])
							{
								case '0':
								case '1':
								case '2':
								case '3':
								case '4':
								case '5':
								case '6':
								case '7':
								case '8':
								case '9':
									tb.BackColor = SystemColors.Window;
									break;
							}
						}
					}
					else
					{
						MessageBox.Show("Моля въведете телефонен номер в правилен формат! \nНапр. 08XXXXXXXX");
						tb.BackColor = Color.Red;
					}
				}
				else
				{
					MessageBox.Show("Моля въведете телефонен номер в правилен формат! \nНапр. 08XXXXXXXX");
					tb.BackColor = Color.Red;
				}
			}
			else
			{
				MessageBox.Show("Моля въведете телефонен номер в правилен формат! \nНапр. 08XXXXXXXX");
				tb.BackColor = Color.Red;
			}
		}

		private void ButtonCheckVaxDate_Click(object sender, EventArgs e)
		{
			//добавя се една година към датата на ваксинация и се изписва в отделен прозорец във формат дд.мм.гггг
			MessageBox.Show($"Дата на следваща ваксинация: {(this.dateTimePickerVax.Value.AddYears(1)).ToString("dd.MM.yyyy")}");
		}

		private void RadioButtonNeuteredNo_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonNeuteredNo.Checked == true)
			{
				MessageBox.Show("Препоръчва се кастриране!");
			}
		}


		//метод за деактивиране на календар и бутон
		private void RadioButtonVaxNo_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerVax.Enabled = false;
			buttonCheckVaxDate.Enabled = false;
		}
		
		//мертод за активиране на календар и бутон
		private void RadioButtonVaxYes_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonVaxYes.Checked == true)
			{
				//извиква специално съобщение с инструкции към потребителя
				MessageBox.Show("Изберете датата на последната ваксинация!");
				dateTimePickerVax.Enabled = true;
				buttonCheckVaxDate.Enabled = true;
			}
		}

		//метод за изчисляване на възраст
		private void TextBoxAge_MouseClick(object sender, MouseEventArgs e)
		{
			textBoxAge.Text = (DateTime.Now.Year - this.dateTimePickerBirth.Value.Year).ToString();
		}

		private void ButtonChoseAvatar_Click(object sender, EventArgs e)
		{
			if (openAvatarDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBoxAvatar.ImageLocation = openAvatarDialog.FileName;
			}
		}

		//генериране и запазване на файл
		private void ButtonSave_Click(object sender, EventArgs e)
		{
			saveFileDialogInfo.DefaultExt = "*.rtf";
			saveFileDialogInfo.Filter = "RTF Files|*.rtf";
			if (saveFileDialogInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK
			&& (saveFileDialogInfo.FileName.Length > 0))
			{
				try
				{
					//Запазване на съдържанието на полето "Заключение от преглед".
					richTextBoxFinalInfo.SaveFile(saveFileDialogInfo.FileName);
				}
				catch (Exception)
				{
					MessageBox.Show("Файлът не беше съхранен, поради грешка в записа!",
					"Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		//метод за попълване на обобщената информация от прегледа
		private void ButtonGenerateFinalInfo_Click(object sender, EventArgs e)
		{
			//попълва се основната информация до момента като име, вид животно, пол и възраст
			richTextBoxFinalInfo.Text = $"Касае се за {textBoxType.Text.ToLower()} на име {textBoxName.Text} от {sex} пол на {textBoxAge.Text} год. \r\n";

			//прави се проверка дали животното е раждали
			if (checkBoxSexGivenBirth.Checked == true)
			{
				richTextBoxFinalInfo.Text += "Животното е раждало до момента.  \r\n";
			}

			//прави се проверка дали животното е кастрирано
			if (radioButtonNeuteredYes.Checked == true)
			{
				richTextBoxFinalInfo.Text += "Животното вече е кастрирано.  \r\n";
			}
			else if (radioButtonNeuteredNo.Checked == true)
			{
				richTextBoxFinalInfo.Text += $"Животното все още не е кастрирано. Препоръчва се разговор със собственика {textBoxOwnerName.Text} на тел: {textBoxOwnerPhone.Text} относно кастриране. \r\n";
			}
			else if (radioButtonNeuteredUnknown.Checked == true)
			{
				richTextBoxFinalInfo.Text += $"Не е известно дали животното е кастрирано. Препоръчва се разговор със собственика {textBoxOwnerName.Text} на тел: {textBoxOwnerPhone.Text}, " +
					$"за да се установи дали е имало оперативна намеса. \r\n";
			}

			//прави се проверка дали животното е ваксинирано
			if (radioButtonVaxNo.Checked == true)
			{
				richTextBoxFinalInfo.Text += $"Животното все още не е ваксинирано. Препоръчва се разговор със собственика {textBoxOwnerName.Text} на тел: {textBoxOwnerPhone.Text} относно ваксиниране. \r\n";
			}
			else if (radioButtonVaxYes.Checked == true)
			{
				richTextBoxFinalInfo.Text += $"Животното е ваксинирано. Следваща имунизация предстои на {dateTimePickerVax.Value.AddYears(1).ToString("dd.MM.yyyy")}. \r\n";
			}

			richTextBoxFinalInfo.Text += $"{textBoxCheckInfo.Text}";

		}

		string sex;

		private void RadioButtonSexMale_CheckedChanged(object sender, EventArgs e)
		{
			checkBoxSexGivenBirth.Enabled = false;
			sex = "мъжки";
		}

		private void RadioButtonSexFemale_CheckedChanged(object sender, EventArgs e)
		{
			checkBoxSexGivenBirth.Enabled = true;
			sex = "женски";
		}
	}
}
