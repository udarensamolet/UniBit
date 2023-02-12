using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46231z_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			this.checkedListBoxCities.Items.Add(this.textBoxCities.Text);
			this.textBoxCities.Text = "";
		}

		private void ButtonCopy_Click(object sender, EventArgs e)
		{
			//checking if there are any marked elements in CheckedListBox
			{
				if (this.checkedListBoxCities.CheckedItems.Count > 0)
				{
					this.listBoxCities.Items.Clear();
					//checking CheckListBox CheckedItems collection using a cycle and adding marked items in ListBox
					foreach(string item in this.checkedListBoxCities.CheckedItems)
					{
						this.listBoxCities.Items.Add(item.ToString());
					}
					//unmarking all checkboxes in CheckedListBox
					for (int i = 0; i < this.checkedListBoxCities.Items.Count; i++)
					{
						this.checkedListBoxCities.SetItemChecked(i, false);
					}	
				}
			}
		}
	}
}
