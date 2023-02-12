using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_1_02
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public struct EmployeeName
		{
			private string fname, mname, lname;
			public EmployeeName(string first, string middle, string last)
			{
				fname = first;
				mname = middle;
				lname = last;
			}

			public string firstName
			{
				get
				{
					return fname;
				}
				set
				{
					fname = firstName;
				}
			}

			public string middleName
			{
				get
				{
					return mname;
				}
				set
				{
					mname = middleName;
				}
			}

			public string lastname
			{
				get
				{
					return lname;
				}
				set
				{
					lname = lastname;
				}
			}

			public override string ToString()
			{
				return (String.Format($"{fname} {mname} {lname}"));
			}

			public string Initials()
			{
				return (String.Format($"{fname.Substring(0, 1)} {mname.Substring(0, 1)} {lname.Substring(0, 1)}"));
			}
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			string first, middle, last;
			first = textBoxFirstName.Text;
			middle = textBoxMiddleName.Text;
			last = textBoxLastName.Text;

			EmployeeName myName = new EmployeeName(first, middle, last);
			string fullName, inits;
			fullName = myName.ToString();
			inits = myName.Initials();
			richTextBox1.Text = "Име на служителя => " + fullName + "\n";
			richTextBox1.Text += "Инициали на служителя => " + inits;

		}
	}
}
