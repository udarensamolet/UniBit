using System;
using System.Windows.Forms;

namespace VSP_46231z_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitializeLinkLabel();
		}

		//declaring an object from LinkLabel type
		internal LinkLabel LinkLabelExample;

		//declaring and initializing the keyword array which will store the link
		string[] keywords;

		//declaring thbe url_addresses array which will store the URL addresses
		string[] url_addresses;

		private void InitializeLinkLabel()
		{
			this.LinkLabelExample = new LinkLabel();
			this.LinkLabelExample.Links.Clear();

			//location, name and size of object linkLabelExample. Location upper left corner (200,300)
			LinkLabelExample.Location = new System.Drawing.Point(200, 30);
			this.LinkLabelExample.Name = "Example Links";

			//size of (180,30)
			this.LinkLabelExample.Size = new System.Drawing.Size(180, 30);
			this.LinkLabelExample.AutoSize = true;

			//LinkBehaviour property for text underlining when hovering over with the mouse
			this.LinkLabelExample.LinkBehavior = LinkBehavior.HoverUnderline;
			string textString = "Главна уеб страница на УниБИТ.\n" + "Подстраница за новини.";

			//text property of LinkLabelExample object
			this.LinkLabelExample.Text = textString;

			//link color
			this.LinkLabelExample.LinkColor = System.Drawing.Color.Blue;

			//active link color
			this.LinkLabelExample.ActiveLinkColor = System.Drawing.Color.Red;

			//LinkLabel_LinkClicked -> LinkClicked event
			this.LinkLabelExample.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel_LinkClicked);

			//filling keywords array with keywords that will become links
			keywords = new string[] { "уеб страница", "новини"};

			//adding keywords to Links collection
			foreach (string keyword in keywords)
			{
				this.LinkLabelExample.Links.Add(textString.IndexOf(keyword), keyword.Length);
			}

			//filling in url_addresses
			url_addresses = new string[] { "www.unibit.bg", "www.unibit.bg/news"};

			//adding LinkLabelExample to form
			this.Controls.Add(this.LinkLabelExample);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = "";

			//case link clicked
			switch (LinkLabelExample.Links.IndexOf(e.Link))
			{
				case 0:
					//web page clicked
					url = url_addresses[0];
					break;
				case 1:
					//news page clicked
					url = url_addresses[1];
					break;
			}

			//property Visited set to True -> allows changing the link color after clicking on it
			e.Link.Visited = true;

			//starting browser
			System.Diagnostics.Process.Start(url);
		}
	}
}
