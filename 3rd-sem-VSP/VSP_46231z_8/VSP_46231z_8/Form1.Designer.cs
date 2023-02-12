namespace VSP_46231z_8
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.labelCurrentPath = new System.Windows.Forms.Label();
			this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
			this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
			this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonTile = new System.Windows.Forms.RadioButton();
			this.radioButtonLargeIcon = new System.Windows.Forms.RadioButton();
			this.radioButtonDetails = new System.Windows.Forms.RadioButton();
			this.radioButtonSmallIcon = new System.Windows.Forms.RadioButton();
			this.radioButtonList = new System.Windows.Forms.RadioButton();
			this.buttonBack = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCurrentPath
			// 
			this.labelCurrentPath.AutoSize = true;
			this.labelCurrentPath.Location = new System.Drawing.Point(12, 24);
			this.labelCurrentPath.Name = "labelCurrentPath";
			this.labelCurrentPath.Size = new System.Drawing.Size(114, 17);
			this.labelCurrentPath.TabIndex = 0;
			this.labelCurrentPath.Text = "labelCurrentPath";
			// 
			// listViewFilesAndFolders
			// 
			this.listViewFilesAndFolders.HideSelection = false;
			this.listViewFilesAndFolders.LargeImageList = this.imageListLarge;
			this.listViewFilesAndFolders.Location = new System.Drawing.Point(15, 50);
			this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
			this.listViewFilesAndFolders.Size = new System.Drawing.Size(478, 304);
			this.listViewFilesAndFolders.SmallImageList = this.imageListSmall;
			this.listViewFilesAndFolders.TabIndex = 2;
			this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
			this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
			// 
			// imageListLarge
			// 
			this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
			this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListLarge.Images.SetKeyName(0, "Open file.png");
			this.imageListLarge.Images.SetKeyName(1, "Scenario.png");
			// 
			// imageListSmall
			// 
			this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
			this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListSmall.Images.SetKeyName(0, "Scenario.png");
			this.imageListSmall.Images.SetKeyName(1, "Open file.png");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonTile);
			this.groupBox1.Controls.Add(this.radioButtonLargeIcon);
			this.groupBox1.Controls.Add(this.radioButtonDetails);
			this.groupBox1.Controls.Add(this.radioButtonSmallIcon);
			this.groupBox1.Controls.Add(this.radioButtonList);
			this.groupBox1.Location = new System.Drawing.Point(499, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 228);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// radioButtonTile
			// 
			this.radioButtonTile.AutoSize = true;
			this.radioButtonTile.Location = new System.Drawing.Point(6, 145);
			this.radioButtonTile.Name = "radioButtonTile";
			this.radioButtonTile.Size = new System.Drawing.Size(52, 21);
			this.radioButtonTile.TabIndex = 9;
			this.radioButtonTile.TabStop = true;
			this.radioButtonTile.Text = "Tile";
			this.radioButtonTile.UseVisualStyleBackColor = true;
			this.radioButtonTile.CheckedChanged += new System.EventHandler(this.RadioButtonTile_CheckedChanged);
			// 
			// radioButtonLargeIcon
			// 
			this.radioButtonLargeIcon.AutoSize = true;
			this.radioButtonLargeIcon.Location = new System.Drawing.Point(6, 37);
			this.radioButtonLargeIcon.Name = "radioButtonLargeIcon";
			this.radioButtonLargeIcon.Size = new System.Drawing.Size(96, 21);
			this.radioButtonLargeIcon.TabIndex = 5;
			this.radioButtonLargeIcon.TabStop = true;
			this.radioButtonLargeIcon.Text = "Large Icon";
			this.radioButtonLargeIcon.UseVisualStyleBackColor = true;
			this.radioButtonLargeIcon.CheckedChanged += new System.EventHandler(this.RadioButtonLargeIcon_CheckedChanged);
			// 
			// radioButtonDetails
			// 
			this.radioButtonDetails.AutoSize = true;
			this.radioButtonDetails.Checked = true;
			this.radioButtonDetails.Location = new System.Drawing.Point(6, 118);
			this.radioButtonDetails.Name = "radioButtonDetails";
			this.radioButtonDetails.Size = new System.Drawing.Size(72, 21);
			this.radioButtonDetails.TabIndex = 8;
			this.radioButtonDetails.TabStop = true;
			this.radioButtonDetails.Text = "Details";
			this.radioButtonDetails.UseVisualStyleBackColor = true;
			this.radioButtonDetails.CheckedChanged += new System.EventHandler(this.RadioButtonDetails_CheckedChanged);
			// 
			// radioButtonSmallIcon
			// 
			this.radioButtonSmallIcon.AutoSize = true;
			this.radioButtonSmallIcon.Location = new System.Drawing.Point(6, 64);
			this.radioButtonSmallIcon.Name = "radioButtonSmallIcon";
			this.radioButtonSmallIcon.Size = new System.Drawing.Size(93, 21);
			this.radioButtonSmallIcon.TabIndex = 6;
			this.radioButtonSmallIcon.TabStop = true;
			this.radioButtonSmallIcon.Text = "Small Icon";
			this.radioButtonSmallIcon.UseVisualStyleBackColor = true;
			this.radioButtonSmallIcon.CheckedChanged += new System.EventHandler(this.RadioButtonSmallIcon_CheckedChanged);
			// 
			// radioButtonList
			// 
			this.radioButtonList.AutoSize = true;
			this.radioButtonList.Location = new System.Drawing.Point(6, 91);
			this.radioButtonList.Name = "radioButtonList";
			this.radioButtonList.Size = new System.Drawing.Size(51, 21);
			this.radioButtonList.TabIndex = 7;
			this.radioButtonList.TabStop = true;
			this.radioButtonList.Text = "List";
			this.radioButtonList.UseVisualStyleBackColor = true;
			this.radioButtonList.CheckedChanged += new System.EventHandler(this.RadioButtonList_CheckedChanged);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(379, 415);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 4;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.ButtonBack_click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listViewFilesAndFolders);
			this.Controls.Add(this.labelCurrentPath);
			this.MaximumSize = new System.Drawing.Size(818, 497);
			this.MinimumSize = new System.Drawing.Size(818, 497);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCurrentPath;
		private System.Windows.Forms.ListView listViewFilesAndFolders;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonTile;
		private System.Windows.Forms.RadioButton radioButtonLargeIcon;
		private System.Windows.Forms.RadioButton radioButtonDetails;
		private System.Windows.Forms.RadioButton radioButtonSmallIcon;
		private System.Windows.Forms.RadioButton radioButtonList;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.ImageList imageListLarge;
		private System.Windows.Forms.ImageList imageListSmall;
	}
}

