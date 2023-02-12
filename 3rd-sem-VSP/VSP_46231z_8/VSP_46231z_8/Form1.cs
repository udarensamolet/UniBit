using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VSP_46231z_8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			folderCol = new System.Collections.Specialized.StringCollection();
			CreateHeadersAndFillListView();
			PaintListView(@"C:\");
			folderCol.Add(@"C:\");
		}

		private System.Collections.Specialized.StringCollection folderCol;

		private void PaintListView(string root)
		{
			try
			{
				//two local variables are used for creating elements for visualising
				ListViewItem lvi;
				ListViewItem.ListViewSubItem lvsi;

				//if main foldres doesn't exist, method stops working
				if (root.CompareTo("") == 0)
					return;

				//getting data for main folder
				DirectoryInfo dir = new DirectoryInfo(root);

				//getting data for folders na dfiles in main dir
				DirectoryInfo[] dirs = dir.GetDirectories(); //folders
				FileInfo[] files = dir.GetFiles();

				//clearing elements list in ListView. Clear method applied to Items collection and not to object ListView. Clear method of ListView object deletes everything, 
				//including column headers too, and in this case only elements from list must be deleted
				this.listViewFilesAndFolders.Items.Clear();

				//saving current path in label
				this.labelCurrentPath.Text = root;

				//object ListView blocked for redrawing
				this.listViewFilesAndFolders.BeginUpdate();

				//checking all folders from root dir with a cycle
				foreach (DirectoryInfo di in dirs)
				{
					//creating main element ListViewItem
					lvi = new ListViewItem();
					lvi.Text = di.Name; // Folder name
					lvi.ImageIndex = 0; // Icon folder gets index 0

					//setting full folder path in Tag property
					lvi.Tag = di.FullName;

					//creating sub-element ListElementSubItems
					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = ""; // Size - folder doesn't have a size

					//Sub-element added to ListViewItem element
					lvi.SubItems.Add(lvsi);

					//creating sub-element ListViewSubItem
					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = di.LastAccessTime.ToString();

					//adding subelement to element ListViewItem
					lvi.SubItems.Add(lvsi);

					//adding element in ListView Items collection
					this.listViewFilesAndFolders.Items.Add(lvi);
				}

				//checking all fields from root dir with a cycle
				foreach (FileInfo fi in files)
				{
					//creating main element ListViewItem
					lvi = new ListViewItem();
					lvi.Text = fi.Name; // file name
					lvi.ImageIndex = 1; // file icon - index 1

					//putting full file path in Tag property
					lvi.Tag = fi.FullName;

					//creating ListViewSubItems subelement
					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = fi.Length.ToString(); // file size
					lvi.SubItems.Add(lvsi); // adding in the SubItems collection

					//creating ListViewSubItems subitem
					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = fi.LastAccessTime.ToString();
					lvi.SubItems.Add(lvsi); //adding in the SubItems collection

					//adding element to the ListView Items collection
					this.listViewFilesAndFolders.Items.Add(lvi);
				}
				//deblocking drawing of ListView control. Items list will be shown
				this.listViewFilesAndFolders.EndUpdate();
			}
			catch (System.Exception err)
			{
				MessageBox.Show("Грешка: " + err.Message);
			}
		}

		private void CreateHeadersAndFillListView()
		{
			//first column
			ColumnHeader colHead;
			colHead = new ColumnHeader();
			colHead.Text = "Папки/Файлове";
			colHead.Width = 200;
			this.listViewFilesAndFolders.Columns.Add(colHead);

			//second column
			colHead = new ColumnHeader();
			colHead.Text = "Размер";
			colHead.Width = 100;
			this.listViewFilesAndFolders.Columns.Add(colHead);

			//third column
			colHead = new ColumnHeader();
			colHead.Text = "Последна модификация";
			colHead.Width = 200;
			this.listViewFilesAndFolders.Columns.Add(colHead);
		}

		private void ListViewFilesAndFolders_ItemActive(object sender, EventArgs e)
		{
			//sender object converted to ListView type
			ListView lw = (ListView)sender;
			//processing Tag property of the first chosen element
			string filename = lw.SelectedItems[0].Tag.ToString();
			if (lw.SelectedItems[0].ImageIndex != 0)
			{
				try
				{
					//try to execute file
					System.Diagnostics.Process.Start(filename);
				}
				catch
				{
					//if unsuccessful -> exiting method
					return;
				}
			}
			else
			{
				//chosen element placed as drawing
				PaintListView(filename);
				folderCol.Add(filename);
			}
		}

		private void ButtonBack_click(object sender, EventArgs e)
		{
			if (folderCol.Count > 1)
			{
				//taking collection last element
				PaintListView(folderCol[folderCol.Count - 2].ToString());
				//deleting collection last element
				folderCol.RemoveAt(folderCol.Count - 1);
			}
			else
			{
				PaintListView(folderCol[0].ToString());
			}
		}

		private void RadioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.listViewFilesAndFolders.View = View.LargeIcon;
			}
		}

		private void RadioButtonSmallIcon_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.listViewFilesAndFolders.View = View.SmallIcon;
			}
		}

		private void RadioButtonList_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.listViewFilesAndFolders.View = View.List;
			}
		}
		private void RadioButtonDetails_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.listViewFilesAndFolders.View = View.Details;
			}
		}

		private void RadioButtonTile_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.listViewFilesAndFolders.View = View.Tile;
			}
		}
	}
}
